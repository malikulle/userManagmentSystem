# Getting started

- This project developed with `.NET CORE MVC and JQuery` by `Mehmet Ali Külle`.
- Project aim is having free Personel Managment System As a two role ; Admin and User.

# Code Overview

- `ShoppingApp/Entities` . This project includes database entities.
    * `ShoppingApp/Entities/Models` . This folder contains Entity Models.
    * `ShoppingApp/Entities/Trackable` . This folder contains Abstarct class and IEntity.
    * `ShoppingApp/Entities/Dtos` . This folder contains Data transfer class for `AutoMapper`.
    * `ShoppingApp/Entities/Enums` . This folder contains Enums.
- `ShoppingApp/Core` . This project includes Generic Repository , Service. And Extensions.
- `ShoppingApp/Data` . This project includes Data access layer , UnitOfWork Pattern.
    * `ShoppingApp/Data/Context` . This folder contains Db Context.
    * `ShoppingApp/Data/Mapping` . This folder contains FluentApi Mapping.
    * `ShoppingApp/Data/UnitOfWork` . This folder contains UnitOfWork Pattern.
- `ShoppingApp/Services` . This project includes project's services.
    * `ShoppingApp/Services/Abstract` . This folder contains Interfaces.
    * `ShoppingApp/Services/Concrete` . This folder contains classes which are implemented from interfaces.
    * `ShoppingApp/Services/ServiceExtension` . This folder contains entity service scoped extension.
- `ShoppingApp/WebMVC` . This project contains MVC project.
    * `Areas/Identity` . This folder is `Security Identity` layer.
    * `AutoMapper` . This folder contains automapper profiles.
    * `Helpers`. This folder contains Helper Services.

## Picture From Project

# Login Page
![Login](https://github.com/malikulle/userManagmentSystem/blob/master/images/1.png?raw=true)
# Register Page
![Register](https://github.com/malikulle/userManagmentSystem/blob/master/images/2.png?raw=true)
# When Admin Logged In
![Register](https://github.com/malikulle/userManagmentSystem/blob/master/images/3.png?raw=true)
# When User Logged In
![Register](https://github.com/malikulle/userManagmentSystem/blob/master/images/4.png?raw=true)
# Added Page For User Leave Type
![Add](https://github.com/malikulle/userManagmentSystem/blob/master/images/44.png?raw=true)
# User Page only have seen by admin
![Users](https://github.com/malikulle/userManagmentSystem/blob/master/images/5.png?raw=true)
# User User Request Request Page
![Request](https://github.com/malikulle/userManagmentSystem/blob/master/images/6.png?raw=true)
# User Request Added Page
![AddedPage](https://github.com/malikulle/userManagmentSystem/blob/master/images/7.png?raw=true)
# User Allocation History Page
![Allocation](https://github.com/malikulle/userManagmentSystem/blob/master/images/8.png?raw=true)
![Allocation](https://github.com/malikulle/userManagmentSystem/blob/master/images/9.png?raw=true)



