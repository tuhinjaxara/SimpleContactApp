
namespace SimpleContactApp.DataAccessLayer
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using Models;

    public class DBInitializer : DbMigrationsConfiguration<DataContext>
    {
        public DBInitializer()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            var customers = new List<Contact>{
                new Contact  {Id = 1, Name ="Alejandra Camino", Address ="Gran Vía, 1", City="Madrid", ZipCode="28001"},
                new Contact  {Id = 2, Name ="Alexander Feuer", Address ="Heerstr. 22", City="Leipzig", ZipCode="04179"},
                new Contact  {Id = 3, Name ="Ana Trujillo", Address ="Avda. de la Constitución 2222", City="México D.F.", ZipCode="05021"},
                new Contact  {Id = 4, Name ="Anabela Domingues", Address ="Av. Inês de Castro, 414", City="Sao Paulo", ZipCode="05634-030"},
                new Contact  {Id = 5, Name ="André Fonseca", Address ="Av. Brasil, 442", City="Campinas", ZipCode="04876-786"},
                new Contact  {Id = 6, Name ="Ann Devon", Address ="35 King George", City="London", ZipCode="WX3 6FW"},
                new Contact  {Id = 7, Name ="Annette Roulet", Address ="1 rue Alsace-Lorraine", City="Toulouse", ZipCode="31000"},
                new Contact  {Id = 8, Name ="Antonio Moreno", Address ="Mataderos  2312", City="México D.F.", ZipCode="05023"},
                new Contact  {Id = 9, Name ="Aria Cruz", Address ="Rua Orós, 92", City="Sao Paulo", ZipCode="05442-030"},
                new Contact  {Id = 10, Name ="Art Braunschweiger", Address ="P.O. Box 555", City="Lander", ZipCode="82520"},
                new Contact  {Id = 11, Name ="Bernardo Batista", Address ="Rua da Panificadora, 12", City="Rio de Janeiro", ZipCode="02389-673"},
                new Contact  {Id = 12, Name ="Carine Schmitt", Address ="54, rue Royale", City="Nantes", ZipCode="44000"},
                new Contact  {Id = 13, Name ="Carlos González", Address ="Carrera 52 con Ave. Bolívar #65-98 Llano Largo", City="Barquisimeto", ZipCode="3508"},
                new Contact  {Id = 14, Name ="Carlos Hernández", Address ="Carrera 22 con Ave. Carlos Soublette #8-35", City="San Cristóbal", ZipCode="5022"},
                new Contact  {Id = 15, Name ="Catherine Dewey", Address ="Rue Joseph-Bens 532", City="Bruxelles", ZipCode="B-1180"},
                new Contact  {Id = 16, Name ="Christina Berglund", Address ="Berguvsvägen  8", City="Luleå", ZipCode="S-958 22"},
                new Contact  {Id = 17, Name ="Daniel Tonini", Address ="67, avenue de l'Europe", City="Versailles", ZipCode="78000"},
                new Contact  {Id = 18, Name ="Diego Roel", Address ="C/ Moralzarzal, 86", City="Madrid", ZipCode="28034"},
                new Contact  {Id = 19, Name ="Dominique Perrier", Address ="25, rue Lauriston", City="Paris", ZipCode="75016"},
                new Contact  {Id = 20, Name ="Eduardo Saavedra", Address ="Rambla de Cataluña, 23", City="Barcelona", ZipCode="08022"},
                new Contact  {Id = 21, Name ="Elizabeth Brown", Address ="Berkeley Gardens 12  Brewery", City="London", ZipCode="WX1 6LT"},
                new Contact  {Id = 22, Name ="Elizabeth Lincoln", Address ="23 Tsawassen Blvd.", City="Tsawassen", ZipCode="T2F 8M4"},
                new Contact  {Id = 23, Name ="Felipe Izquierdo", Address ="Ave. 5 de Mayo Porlamar", City="I. de Margarita", ZipCode="4980"},
                new Contact  {Id = 24, Name ="Fran Wilson", Address ="89 Chiaroscuro Rd.", City="Portland", ZipCode="97219"},
                new Contact  {Id = 25, Name ="Francisco Chang", Address ="Sierras de Granada 9993", City="México D.F.", ZipCode="05022"},
                new Contact  {Id = 26, Name ="Frédérique Citeaux", Address ="24, place Kléber", City="Strasbourg", ZipCode="67000"},
                new Contact  {Id = 27, Name ="Georg Pipps", Address ="Geislweg 14", City="Salzburg", ZipCode="5020"},
                new Contact  {Id = 28, Name ="Giovanni Rovelli", Address ="Via Ludovico il Moro 22", City="Bergamo", ZipCode="24100"},
                new Contact  {Id = 29, Name ="Guillermo Fernández", Address ="Calle Dr. Jorge Cash 321", City="México D.F.", ZipCode="05033"},
                new Contact  {Id = 30, Name ="Hanna Moos", Address ="Forsterstr. 57", City="Mannheim", ZipCode="68306"},
                new Contact  {Id = 31, Name ="Hari Kumar", Address ="90 Wadhurst Rd.", City="London", ZipCode="OX15 4NB"},
                new Contact  {Id = 32, Name ="Helen Bennett", Address ="Garden House Crowther Way", City="Cowes", ZipCode="PO31 7PJ"},
                new Contact  {Id = 33, Name ="Helvetius Nagy", Address ="722 DaVinci Blvd.", City="Kirkland", ZipCode="98034"},
                new Contact  {Id = 34, Name ="Henriette Pfalzheim", Address ="Mehrheimerstr. 369", City="Köln", ZipCode="50739"},
                new Contact  {Id = 35, Name ="Horst Kloss", Address ="Taucherstraße 10", City="Cunewalde", ZipCode="01307"},
                new Contact  {Id = 36, Name ="Howard Snyder", Address ="2732 Baker Blvd.", City="Eugene", ZipCode="97403"},
                new Contact  {Id = 37, Name ="Isabel de Castro", Address ="Estrada da saúde n. 58", City="Lisboa", ZipCode="1756"},
                new Contact  {Id = 38, Name ="Jaime Yorres", Address ="87 Polk St. Suite 5", City="San Francisco", ZipCode="94117"},
                new Contact  {Id = 39, Name ="Janete Limeira", Address ="Av. Copacabana, 267", City="Rio de Janeiro", ZipCode="02389-890"},
                new Contact  {Id = 40, Name ="Janine Labrune", Address ="67, rue des Cinquante Otages", City="Nantes", ZipCode="44000"},
                new Contact  {Id = 41, Name ="Jean Fresnière", Address ="43 rue St. Laurent", City="Montréal", ZipCode="H1J 1C3"},
                new Contact  {Id = 42, Name ="John Steel", Address ="12 Orchestra Terrace", City="Walla Walla", ZipCode="99362"},
                new Contact  {Id = 43, Name ="Jonas Bergulfsen", Address ="Erling Skakkes gate 78", City="Stavern", ZipCode="4110"},
                new Contact  {Id = 44, Name ="Jose Pavarotti", Address ="187 Suffolk Ln.", City="Boise", ZipCode="83720"},
                new Contact  {Id = 45, Name ="José Pedro Freyre", Address ="C/ Romero, 33", City="Sevilla", ZipCode="41101"},
                new Contact  {Id = 46, Name ="Jytte Petersen", Address ="Vinbæltet 34", City="Kobenhavn", ZipCode="1734"},
                new Contact  {Id = 47, Name ="Karin Josephs", Address ="Luisenstr. 48", City="Münster", ZipCode="44087"},
                new Contact  {Id = 48, Name ="Karl Jablonski", Address ="305 - 14th Ave. S. Suite 3B", City="Seattle", ZipCode="98128"},
                new Contact  {Id = 49, Name ="Laurence Lebihan", Address ="12, rue des Bouchers", City="Marseille", ZipCode="13008"},
                new Contact  {Id = 50, Name ="Lino Rodriguez", Address ="Jardim das rosas n. 32", City="Lisboa", ZipCode="1675"},
                new Contact  {Id = 51, Name ="Liu Wong", Address ="55 Grizzly Peak Rd.", City="Butte", ZipCode="59801"},
                new Contact  {Id = 52, Name ="Liz Nixon", Address ="89 Jefferson Way Suite 2", City="Portland", ZipCode="97201"},
                new Contact  {Id = 53, Name ="Lúcia Carvalho", Address ="Alameda dos Canàrios, 891", City="Sao Paulo", ZipCode="05487-020"},
                new Contact  {Id = 54, Name ="Manuel Pereira", Address ="5ª Ave. Los Palos Grandes", City="Caracas", ZipCode="1081"},
                new Contact  {Id = 55, Name ="Maria Anders", Address ="Obere Str. 57", City="Berlin", ZipCode="12209"},
                new Contact  {Id = 56, Name ="Maria Larsson", Address ="Åkergatan 24", City="Bräcke", ZipCode="S-844 67"},
                new Contact  {Id = 57, Name ="Marie Bertrand", Address ="265, boulevard Charonne", City="Paris", ZipCode="75012"},
                new Contact  {Id = 58, Name ="Mario Pontes", Address ="Rua do Paço, 67", City="Rio de Janeiro", ZipCode="05454-876"},
                new Contact  {Id = 59, Name ="Martín Sommer", Address ="C/ Araquil, 67", City="Madrid", ZipCode="28023"},
                new Contact  {Id = 60, Name ="Martine Rancé", Address ="184, chaussée de Tournai", City="Lille", ZipCode="59000"},
                new Contact  {Id = 61, Name ="Mary Saveley", Address ="2, rue du Commerce", City="Lyon", ZipCode="69004"},
                new Contact  {Id = 62, Name ="Matti Karttunen", Address ="Keskuskatu 45", City="Helsinki", ZipCode="21240"},
                new Contact  {Id = 63, Name ="Maurizio Moroni", Address ="Strada Provinciale 124", City="Reggio Emilia", ZipCode="42100"},
                new Contact  {Id = 64, Name ="Michael Holz", Address ="Grenzacherweg 237", City="Genève", ZipCode="1203"},
                new Contact  {Id = 65, Name ="Miguel Angel Paolino", Address ="Avda. Azteca 123", City="México D.F.", ZipCode="05033"},
                new Contact {Id = 66, Name ="Palle Ibsen", Address ="Smagsloget 45", City="Århus", ZipCode="8200"},
                new Contact {Id = 67, Name ="Paolo Accorti", Address ="Via Monte Bianco 34", City="Torino", ZipCode="10100"},
                new Contact {Id = 68, Name ="Pascale Cartrain", Address ="Boulevard Tirou, 255", City="Charleroi", ZipCode="B-6000"},
                new Contact {Id = 70, Name ="Patricio Simpson", Address ="Cerrito 333", City="Buenos Aires", ZipCode="1010"},
                new Contact {Id = 71, Name ="Paul Henriot", Address ="59 rue de l'Abbaye", City="Reims", ZipCode="51100"},
                new Contact {Id = 72, Name ="Paula Parente", Address ="Rua do Mercado, 12", City="Resende", ZipCode="08737-363"},
                new Contact {Id = 73, Name ="Paula Wilson", Address ="2817 Milton Dr.", City="Albuquerque", ZipCode="87110"},
                new Contact {Id = 74, Name ="Pedro Afonso", Address ="Av. dos Lusíadas, 23", City="Sao Paulo", ZipCode="05432-043"},
                new Contact {Id = 75, Name ="Peter Franken", Address ="Berliner Platz 43", City="München", ZipCode="80805"},
                new Contact {Id = 76, Name ="Philip Cramer", Address ="Maubelstr. 90", City="Brandenburg", ZipCode="14776"},
                new Contact {Id = 77, Name ="Pirkko Koskitalo", Address ="Torikatu 38", City="Oulu", ZipCode="90110"},
                new Contact {Id = 78, Name ="Renate Messner", Address ="Magazinweg 7", City="Frankfurt a.M.", ZipCode="60528"},
                new Contact {Id = 79, Name ="Rene Phillips", Address ="2743 Bering St.", City="Anchorage", ZipCode="99508"},
                new Contact {Id = 80, Name ="Rita Müller", Address ="Adenauerallee 900", City="Stuttgart", ZipCode="70563"},
                new Contact {Id = 81, Name ="Roland Mendel", Address ="Kirchgasse 6", City="Graz", ZipCode="8010"},
                new Contact {Id = 82, Name ="Sergio Gutiérrez", Address ="Av. del Libertador 900", City="Buenos Aires", ZipCode="1010"},
                new Contact {Id = 83, Name ="Simon Crowther", Address ="South House 300 Queensbridge", City="London", ZipCode="SW7 1RZ"},
                new Contact {Id = 84, Name ="Sven Ottlieb", Address ="Walserweg 21", City="Aachen", ZipCode="52066"},
                new Contact {Id = 85, Name ="Thomas Hardy", Address ="120 Hanover Sq.", City="London", ZipCode="WA1 1DP"},
                new Contact {Id = 86, Name ="Victoria Ashworth", Address ="Fauntleroy Circus", City="London", ZipCode="EC2 5NT"},
                new Contact {Id = 87, Name ="Yang Wang", Address ="Hauptstr. 29", City="Bern", ZipCode="3012"},
                new Contact {Id = 88, Name ="Yoshi Latimer", Address ="City Center Plaza 516 Main St.", City="Elgin", ZipCode="97827"},
                new Contact {Id = 89, Name ="Yoshi Tannamuri", Address ="1900 Oak St.", City="Vancouver", ZipCode="V3F 2K1"},
                new Contact {Id = 90, Name ="Yvonne Moncada", Address ="Ing. Gustavo Moncada 8585 Piso 20-A", City="Buenos Aires", ZipCode="1010"},
                new Contact {Id = 91, Name ="Zbyszek Piestrzeniewicz", Address ="ul. Filtrowa 68", City="Warszawa", ZipCode="01-012"}
            };

            customers.ForEach(s => context.Contacts.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}