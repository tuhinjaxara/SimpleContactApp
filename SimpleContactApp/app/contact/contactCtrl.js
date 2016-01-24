var app = angular.module("SimpleContactApp")
app.controller('contactCtrl', ['$scope', '$state', '$stateParams', '$modal', '$log', 'Contact', function ($scope, $state, $stateParams, $modal, $log, Contact) {

    var id = $stateParams.id;

    $scope.searchText = '';
    $scope.pageSize = 10;
    $scope.pageNumber = 1;
    $scope.totalCount = 0;
    $scope.orderBy = 'name';
    $scope.contacts = searchContacts();
    $scope.contact = null;
    $scope.currentContact = null;


    $scope.pageChanged = function () {
        searchContacts();
    }

    $scope.$watch('searchText', function (newVal, oldVal) {
        if (newVal != oldVal) {
            searchContacts();
        }
    }, true);


    //function searchContacts() {
    //    Contact.search($scope.searchText)
    //    .then(function (data) {
    //        $scope.contacts = Contact.contacts;
    //    });
    //};

    function searchContacts() {
        Contact.searchWithPagination($scope.searchText, $scope.pageSize, $scope.pageNumber, $scope.orderBy)
        .then(function (data) {
            $scope.contacts = Contact.data.Contacts;
            $scope.totalCount = Contact.data.TotalCount;
            $scope.totalPages = Contact.data.totalPages;
        });
    };

    $scope.contactDetail = function (id) {
        if (!id) return;
        Contact.contactDetail(id)
        .then(function (data) {
            $scope.currentContact = Contact.currentContact;
            $state.go('contact.detail', { 'id': id });
        });
    };

    /* Need to call after defining the function
       It will be called on page refresh        */
    $scope.currentContact = $scope.contactDetail(id);

    // Delete a contact and hide the row
    $scope.deleteContact = function ($event, id) {
        var ans = confirm('Are you sure to delete it?');
        if (ans) {
            Contact.delete(id)
                .then(function() {
                    var element = $event.currentTarget;
                    $(element).closest('div[class^="col-lg-12"]').hide();
                });
        }
    };

    // Add Contact
    $scope.addContact = function () {
        Contact.newContact()
        .then(function (data) {
            //$scope.contact = Contact.contact;
            $scope.open('lg');
        });
    }

    // Edit Contact
    $scope.editContact = function (id) {
        if (!id) return;
        Contact.contactDetail(id)
        .then(function (data) {
            $scope.currentContact = Contact.currentContact;
            $scope.contact = $scope.currentContact;
            $scope.open('lg');
        });
    }

    // Open model to add edit Contact
    $scope.open = function (size) {        
        var modalInstance = $modal.open({
            animation: false,
            backdrop: 'static',
            templateUrl: 'app/contact/AddEditContact.html',
            controller: 'contactModalCtrl',
            size: size,
            resolve: {
                contact: function () {
                    return $scope.contact;
                }
            }
        });
        modalInstance.result.then(function (response) {
            $scope.currentContact = response;
            var index = $scope.contacts.findIndex(function(item) {
                return item.Id == response.Id;
            });
            if (index > -1) {
                $scope.contacts[index] = response;
                $scope.contact = {};
            } else {
                $scope.contacts.push(response);
            }
        }, function () {
            $log.info('Modal dismissed at: ' + new Date());
        });
    };


    
}]);

app.controller('contactModalCtrl', ['$scope', '$modalInstance', 'Contact', 'contact', function ($scope, $modalInstance, Contact, contact) {

    $scope.contact = contact;
    
    if (contact)
        $scope.headerTitle = 'Edit contact';
    else
        $scope.headerTitle = 'Add contact';
    
    $scope.save = function () {
        Contact.Save($scope.contact).then(function (response) {
            contact = {};
            $modalInstance.close(response.data);
        });
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };

}]);
