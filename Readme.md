<a name='assembly'></a>
# ExpenseTracker

## Contents

- [Budgets](#T-ExpenseTracker-Models-Budgets 'ExpenseTracker.Models.Budgets')
  - [Amount](#P-ExpenseTracker-Models-Budgets-Amount 'ExpenseTracker.Models.Budgets.Amount')
  - [Budget_Id](#P-ExpenseTracker-Models-Budgets-Budget_Id 'ExpenseTracker.Models.Budgets.Budget_Id')
  - [End_Date](#P-ExpenseTracker-Models-Budgets-End_Date 'ExpenseTracker.Models.Budgets.End_Date')
  - [Start_Date](#P-ExpenseTracker-Models-Budgets-Start_Date 'ExpenseTracker.Models.Budgets.Start_Date')
- [Categorys](#T-ExpenseTracker-Models-Categorys 'ExpenseTracker.Models.Categorys')
  - [Category_Id](#P-ExpenseTracker-Models-Categorys-Category_Id 'ExpenseTracker.Models.Categorys.Category_Id')
  - [Description](#P-ExpenseTracker-Models-Categorys-Description 'ExpenseTracker.Models.Categorys.Description')
  - [Name](#P-ExpenseTracker-Models-Categorys-Name 'ExpenseTracker.Models.Categorys.Name')
- [CategorysController](#T-ExpenseTracker-Controllers-CategorysController 'ExpenseTracker.Controllers.CategorysController')
- [ExpenseTrackerContext](#T-ExpenseTracker-Data-ExpenseTrackerContext 'ExpenseTracker.Data.ExpenseTrackerContext')
  - [#ctor(options)](#M-ExpenseTracker-Data-ExpenseTrackerContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{ExpenseTracker-Data-ExpenseTrackerContext}- 'ExpenseTracker.Data.ExpenseTrackerContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{ExpenseTracker.Data.ExpenseTrackerContext})')
  - [Users](#P-ExpenseTracker-Data-ExpenseTrackerContext-Users 'ExpenseTracker.Data.ExpenseTrackerContext.Users')
- [Expenses](#T-ExpenseTracker-Models-Expenses 'ExpenseTracker.Models.Expenses')
  - [Amount](#P-ExpenseTracker-Models-Expenses-Amount 'ExpenseTracker.Models.Expenses.Amount')
  - [Date](#P-ExpenseTracker-Models-Expenses-Date 'ExpenseTracker.Models.Expenses.Date')
  - [Description](#P-ExpenseTracker-Models-Expenses-Description 'ExpenseTracker.Models.Expenses.Description')
  - [Expense_Id](#P-ExpenseTracker-Models-Expenses-Expense_Id 'ExpenseTracker.Models.Expenses.Expense_Id')
- [PaymentMethods](#T-ExpenseTracker-Models-PaymentMethods 'ExpenseTracker.Models.PaymentMethods')
  - [Name](#P-ExpenseTracker-Models-PaymentMethods-Name 'ExpenseTracker.Models.PaymentMethods.Name')
  - [Payment_Method_Id](#P-ExpenseTracker-Models-PaymentMethods-Payment_Method_Id 'ExpenseTracker.Models.PaymentMethods.Payment_Method_Id')
- [Users](#T-ExpenseTracker-Models-Users 'ExpenseTracker.Models.Users')
  - [Created_At](#P-ExpenseTracker-Models-Users-Created_At 'ExpenseTracker.Models.Users.Created_At')
  - [Email](#P-ExpenseTracker-Models-Users-Email 'ExpenseTracker.Models.Users.Email')
  - [Name](#P-ExpenseTracker-Models-Users-Name 'ExpenseTracker.Models.Users.Name')
  - [Password](#P-ExpenseTracker-Models-Users-Password 'ExpenseTracker.Models.Users.Password')
  - [User_Id](#P-ExpenseTracker-Models-Users-User_Id 'ExpenseTracker.Models.Users.User_Id')
- [UsersController](#T-ExpenseTracker-Controllers-UsersController 'ExpenseTracker.Controllers.UsersController')
  - [#ctor(context)](#M-ExpenseTracker-Controllers-UsersController-#ctor-ExpenseTracker-Data-ExpenseTrackerContext- 'ExpenseTracker.Controllers.UsersController.#ctor(ExpenseTracker.Data.ExpenseTrackerContext)')
  - [Delete(User_id)](#M-ExpenseTracker-Controllers-UsersController-Delete-System-Int32- 'ExpenseTracker.Controllers.UsersController.Delete(System.Int32)')
  - [Get()](#M-ExpenseTracker-Controllers-UsersController-Get 'ExpenseTracker.Controllers.UsersController.Get')
  - [GetByUserId(User_id)](#M-ExpenseTracker-Controllers-UsersController-GetByUserId-System-Int32- 'ExpenseTracker.Controllers.UsersController.GetByUserId(System.Int32)')
  - [Post(User)](#M-ExpenseTracker-Controllers-UsersController-Post-ExpenseTracker-Models-Users- 'ExpenseTracker.Controllers.UsersController.Post(ExpenseTracker.Models.Users)')
  - [Put(User_id,User)](#M-ExpenseTracker-Controllers-UsersController-Put-System-Int32,ExpenseTracker-Models-Users- 'ExpenseTracker.Controllers.UsersController.Put(System.Int32,ExpenseTracker.Models.Users)')

<a name='T-ExpenseTracker-Models-Budgets'></a>
## Budgets `type`

##### Namespace

ExpenseTracker.Models

##### Summary

Class that represents budgets

<a name='P-ExpenseTracker-Models-Budgets-Amount'></a>
### Amount `property`

##### Summary

Gets or sets the amount.

<a name='P-ExpenseTracker-Models-Budgets-Budget_Id'></a>
### Budget_Id `property`

##### Summary

Gets or sets the budget identifier.

<a name='P-ExpenseTracker-Models-Budgets-End_Date'></a>
### End_Date `property`

##### Summary

Gets or sets the end date.

<a name='P-ExpenseTracker-Models-Budgets-Start_Date'></a>
### Start_Date `property`

##### Summary

Gets or sets the start date.

<a name='T-ExpenseTracker-Models-Categorys'></a>
## Categorys `type`

##### Namespace

ExpenseTracker.Models

##### Summary

Class that represents categorys

<a name='P-ExpenseTracker-Models-Categorys-Category_Id'></a>
### Category_Id `property`

##### Summary

Gets or sets the category identifier.

<a name='P-ExpenseTracker-Models-Categorys-Description'></a>
### Description `property`

##### Summary

Gets or sets the description.

<a name='P-ExpenseTracker-Models-Categorys-Name'></a>
### Name `property`

##### Summary

Gets or sets the name.

<a name='T-ExpenseTracker-Controllers-CategorysController'></a>
## CategorysController `type`

##### Namespace

ExpenseTracker.Controllers

##### Summary

Controller for managing categorys

<a name='T-ExpenseTracker-Data-ExpenseTrackerContext'></a>
## ExpenseTrackerContext `type`

##### Namespace

ExpenseTracker.Data

<a name='M-ExpenseTracker-Data-ExpenseTrackerContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{ExpenseTracker-Data-ExpenseTrackerContext}-'></a>
### #ctor(options) `constructor`

##### Summary

Database context for the ExpenseTracker application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{ExpenseTracker.Data.ExpenseTrackerContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{ExpenseTracker-Data-ExpenseTrackerContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{ExpenseTracker.Data.ExpenseTrackerContext}') | Options for configuration the context. |

##### Remarks

Constructor that accepts options for configuring the context.

<a name='P-ExpenseTracker-Data-ExpenseTrackerContext-Users'></a>
### Users `property`

##### Summary

Collection of date for entity Users

<a name='T-ExpenseTracker-Models-Expenses'></a>
## Expenses `type`

##### Namespace

ExpenseTracker.Models

##### Summary

Class represents expenses

<a name='P-ExpenseTracker-Models-Expenses-Amount'></a>
### Amount `property`

##### Summary

Gets or sets the amount.

<a name='P-ExpenseTracker-Models-Expenses-Date'></a>
### Date `property`

##### Summary

Gets or sets the date.

<a name='P-ExpenseTracker-Models-Expenses-Description'></a>
### Description `property`

##### Summary

Gets or sets the description.

<a name='P-ExpenseTracker-Models-Expenses-Expense_Id'></a>
### Expense_Id `property`

##### Summary

Gets or sets the expense identifier.

<a name='T-ExpenseTracker-Models-PaymentMethods'></a>
## PaymentMethods `type`

##### Namespace

ExpenseTracker.Models

##### Summary

Class that represents PaymentMethods

<a name='P-ExpenseTracker-Models-PaymentMethods-Name'></a>
### Name `property`

##### Summary

Gets or sets the name.

<a name='P-ExpenseTracker-Models-PaymentMethods-Payment_Method_Id'></a>
### Payment_Method_Id `property`

##### Summary

Gets or sets the payment method identifier.

<a name='T-ExpenseTracker-Models-Users'></a>
## Users `type`

##### Namespace

ExpenseTracker.Models

##### Summary

Class represents User in system

<a name='P-ExpenseTracker-Models-Users-Created_At'></a>
### Created_At `property`

##### Summary

Gets or sets the created at.

<a name='P-ExpenseTracker-Models-Users-Email'></a>
### Email `property`

##### Summary

Gets or sets the email.

<a name='P-ExpenseTracker-Models-Users-Name'></a>
### Name `property`

##### Summary

Gets or sets the name.

<a name='P-ExpenseTracker-Models-Users-Password'></a>
### Password `property`

##### Summary

Gets or sets the password.

<a name='P-ExpenseTracker-Models-Users-User_Id'></a>
### User_Id `property`

##### Summary

Gets or sets the user identifier.

<a name='T-ExpenseTracker-Controllers-UsersController'></a>
## UsersController `type`

##### Namespace

ExpenseTracker.Controllers

##### Summary

Controller for managing courses in the application.

<a name='M-ExpenseTracker-Controllers-UsersController-#ctor-ExpenseTracker-Data-ExpenseTrackerContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [UsersController](#T-ExpenseTracker-Controllers-UsersController 'ExpenseTracker.Controllers.UsersController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [ExpenseTracker.Data.ExpenseTrackerContext](#T-ExpenseTracker-Data-ExpenseTrackerContext 'ExpenseTracker.Data.ExpenseTrackerContext') | The context. |

<a name='M-ExpenseTracker-Controllers-UsersController-Delete-System-Int32-'></a>
### Delete(User_id) `method`

##### Summary

Deletes user by id

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| User_id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The user identifier. |

<a name='M-ExpenseTracker-Controllers-UsersController-Get'></a>
### Get() `method`

##### Summary

Retrieves all users

##### Parameters

This method has no parameters.

<a name='M-ExpenseTracker-Controllers-UsersController-GetByUserId-System-Int32-'></a>
### GetByUserId(User_id) `method`

##### Summary

Retrievers user by id

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| User_id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The user identifier. |

<a name='M-ExpenseTracker-Controllers-UsersController-Post-ExpenseTracker-Models-Users-'></a>
### Post(User) `method`

##### Summary

Adds new user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| User | [ExpenseTracker.Models.Users](#T-ExpenseTracker-Models-Users 'ExpenseTracker.Models.Users') | The user. |

<a name='M-ExpenseTracker-Controllers-UsersController-Put-System-Int32,ExpenseTracker-Models-Users-'></a>
### Put(User_id,User) `method`

##### Summary

Updates new user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| User_id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The user identifier. |
| User | [ExpenseTracker.Models.Users](#T-ExpenseTracker-Models-Users 'ExpenseTracker.Models.Users') | The user. |
