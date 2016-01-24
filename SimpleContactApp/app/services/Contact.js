angular.module('SimpleContactApp')
       .factory('Contact', ['$q', '$http', function ($q, $http) {

           var baseUrl = 'api/contact/';

           var contactService = {};
           contactService.contacts = [];
           contactService.data = {};
           contactService.currentContact = {};

           // Search Contacts
           contactService.search = function (text) {
               var deferred = $q.defer();
               return $http({
                   url: baseUrl + 'search',
                   method: 'GET',
                   params: { 'searchText': text },
                   cache: true
               }).success(function(data) {
                   deferred.resolve(
                       contactService.contacts = data);
               }).error(function(error) {
                   deferred.reject(error);
               });
               return deferred.promise;
           }
           // Search Contacts with pagination
           contactService.searchWithPagination = function (text, pageSize, pageNumber, orderBy) {
               var deferred = $q.defer();
               return $http({
                   url: baseUrl + 'searchwithpagination',
                   method: 'GET',
                   params: { 'searchText': text, 'pageSize': pageSize, 'pageNumber': pageNumber, 'orderBy': orderBy },
                   cache: true
               }).success(function(data) {
                   deferred.resolve(
                       //contactService.contacts = data.Contacts
                       contactService.data=data);
               }).error(function(error) {
                   deferred.reject(error);
               });
               return deferred.promise;
           }

           // New Contacts
           contactService.newContact = function () {
               var deferred = $q.defer();
               return $http.get(baseUrl + "new")
                   .success(function(data) {
                       deferred.resolve(contactService.cotact = data);
                   })
                   .error(function(error) {
                       deferred.reject(error);
                   });
               return deferred.promise;
           }

           // Save Contact
           contactService.Save = function (contact, files) {
               var deferred = $q.defer();
               return $http.post(baseUrl + "Save", contact)
                .success(function (data) {
                    deferred.resolve(contactService.contact = data);
                })

               .error(function (error) {
                   deferred.reject(error);
               });
               return deferred.promise;
           }

           // contacts detail by contact id
           contactService.contactDetail = function (id) {
               var deferred = $q.defer();
               return $http.get(baseUrl + "detail/" + id)
                   .success(function(data) {
                       deferred.resolve(
                           contactService.currentContact = data);
                   })
                   .error(function(error) {
                       deferred.reject(error);
                   });
               return deferred.promise;
           }

           // delete contacts
           contactService.delete = function (id) {
               var deferred = $q.defer();
               return $http.post(baseUrl + "delete/" + id)
                   .success(function(data) {
                       deferred.resolve();
                   })
                   .error(function(error) {
                       deferred.reject(error);
                   });
               return deferred.promise;
           }
                      
           /*       contact CONTACTS
            ************************************/
           contactService.contactContacts = function (id) {
               var deferred = $q.defer();
               return $http.get(contactBaseUrl + "ByContactId/" + id)
                   .success(function(data) {
                       deferred.resolve(contactService.conntacts = data);
                   }).error(function(error) {
                       deferred.reject(error);
                   });
               return deferred.promise;
           }

           return contactService;
       }]);