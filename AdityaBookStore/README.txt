Name: Aditya Suthar
Project :-  Assignemnt -2 Part-4
Updated Date : 2023/11/21
Time Started : 0316

************************
Assignment-2 Part One 

************************


Date: 27 October 2023
Time 1023

Hello Sir, this me again in the new assignment of asp.net assignment 2 
which is just 5% so i hope i will get it done in 10-8hrs max lets hope.

so in this assignment the catch is we have all the things that we need to do which is provided by you sir in the pptx form 
and we just need to follow those steps.

in the last assignment was not able to do it in ym mac i will first try to do the thing in mac if it won't run in it then as assignment 1 we
go in the computer lab and do this thing.but i dont think is gonna work so we will head toowards src lab.......


Date: October 27, 2023
Time 0233

First of all we have to create and mvc core web app in which we will do the following steps that were displayed clearly in the pptx 
that we will name the applicatioN "AdityaBookStore"

in which we change the authentication to individual able the runtime compilation 

looked at all the files as sir describided in the pptx and also looked at every folder to be familiar with it and also run the application 
and this time theres a new new thing that we have seen was the registr and login information in the right side top 

now we will change the line in the startup.cs file as described in the presentation.

Date: 27 October  2023
Time 0754

Created the git hub respoartatriy which is private one i dont know why but i think we will do same and excat thing as it was described in the pptx. did that and named the Resporatitory : AdityabookStore_0835715.

Added the Break points in the index and privacy and also checked it it was running as it was supposed to 

in the bootstrapwatch.com i have to choose the theme for my website and CHOOSEN THE lux theme and downloaded the bootstrap.css

replace the bootstrap.css file with the new one which located in the wwwrooot folder and replace one more file from the sir provided in the 
site.css file in the assignment-2 folder.


Date: 27 October 2023
Time 1223


linked properly in the _layout.cshtml file by replacing in the file name from bootstrap.min.css to bootstrap.css

in the two files called _layout.cshtml and _loginPartial.cshtml and changed the lines as describeded in the pptx like we have to remove from some place the dark-nav and add some content in the footer and all did it and all runned the application and it looks nice 
as the lux theme should look like.....

Added the Addition stylesheet and javascript links in the _layout.cshtml by adding the css links in the top and javascript link in the bootom and also we will add the dropdown menu with code in the layout.cshtml file right now its just a dummy



Date: 28 October 2023
Time 0954



but maybe will add in the future and make it working right now is working but just as a look wise not the funcatnality i guess.

Now we will create a a three new projects named as AdityaBooks.Models , AdityaBooks.utilty and AdityaBook.DataAccess and all will be created in the 3.1net core not in the 5.0 core which is created in the main project.

we will copy the data folder in the dataAcess prject and deleter the original one and then installed the microsoft.entity and sqlserver and Relational with the help of pmc commad line and then we will delete the migration file. totallly hope it runns still,because i changed too much......

install the pacakage.identity.entity.framework....

Date: 28 October  2023
Time 1123

also one more thing i missed in the pervious step because of which my error were not gonna after installing package we have to add the itemgroup in the DataAccess.csproj file.

and now we will modifiy the name space in the data.cs file from AdityaBookStore.Data to AdityaBookStore.DataAccess.Data

After that deleted the all Class1.cs file from all three project.


Date: 28 October 2023
Time 1212




move the models folder into the model project

now we will change the error.cshtml fiel and edit the line in the @model and we will give the project reference add we will add the dataAccess and model and we will modify 
the errorviewmodel.cs file with the viewmodel

in the startup.cs added the proper link for data new location.

Date: 28 October 2023
Time 0310


resolved all the red lines from every where and now we will try to bulid the project and runned the project.

in the utitly project we will add the SD.cs file and give the remaining project reference for the Utility with main project. in the dataAccess prject we will give the reference to the remaining prject except the main project

Created the new Area Customer in the Area Folder change the route in the startup.cs file.

move the homecontroller.cs from controllers to area>Customer>Controller and also deleted the daata and models folder in the Customer folder.

in the Home Controller.cs added the [Area("customer")]

Date: 28 October 27, 2023
Time 0645



Also Chnaged the Home Folder from the Main to in the Customer Folder and also chaned the namspace.

and in the view added the the viewtart file and viewimport file to make it look as bfore otherwise it look just as sir showned in the picture :(

Date: 28 October 2023
Time 1002

chaged the path of the_viewstart.cshtml file 

now runned the application again and hurryyyyyyy it running as it supposed to look like..... happyyyyyyy....y..y.y..

Date: 29 October 2023
Time 0910


Now we will add a new Area named the area.....named Admin...added similar view files as the Customer and remove the data and models folder.

Date: 29 October 2023
Time 1254

Updated the full code in the Github Respo and i think i am reday to show assignmnet in class and submit the github link to sir.....

Thank you.....




***************  Assignment - 2 ****** PART-2  *************

Date: 10/31/2023
Time : 0441



****************** 2.1 MIGRATION *******************

After receving -1 Mark for readme This time we will start the readme first and push it....


Changed the AppSetting.json File and in the LocaDb = Named the AdityaBookStore
 After that in the proper project add this migration code to create the migration

 --add-migration AddDefaultIdentityMigration

 Updated the database 

PM> update-database
Build started...
Build succeeded.
Done.

Database Has been Created and also Checked on the SQL server Object Explorer
there is table i can see and also runned my project again and everything is looking good as it suppose to look 


Created the New Models called the Category.cs and also did the migration of this Class 

here is the code 

Done.
PM> add-migration AddCategoryToDB
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
PM> 

Time : 0518

In the Models Prject add the new Class Category.cs

in which we add the content as follows 



    and then we did the ApplicationDbContext.cs file and added the nesseacry Using System and the code line for category 

           public DbSet<Category> Categories { get; set; }


           And then we checked our Sql SOE thing and there we can see the table after doing the migration-2

           PM> add-migration AddCategoryToDB
Build started...
Build succeeded.
The name 'AddCategoryToDB' is used by an existing migration.
PM> add-migration AddCategoryToDB-2
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
PM> update-database
Build started...
Build succeeded.
Done.
PM> 
 and then we also have to Update the Database otherwise we can't able to see the category table in the Sql Soe

And Now At the Time : 0522

We Will push this 2.1 Migration into the GitHub 


****************** 2.2 REPOSITORY *******************

its 0552 

Till Nowi am on the Half of the @.2 Repository it was really like a roller coster ..... omggggg

let me explain what i did in past 30,min

 We created the new folder Repository in the DataAccess project and then in the repository dierctory i create new directory called iRepo 
  then in Ireposiroty.Cs we updated the Full Code to this

  that was given in by the sir in the pptx file 



then we add the interface in the Repository.cs and the whole code was generated byit self but we didnt use that sir provided us with the filein assignment-2 folder we used that insteatdd ofthe whole code and 
in between all theese therewas a lot of Using system statement was added and revomed by the use which was not described in the pptx.

Then We created two new .cs File One For Repository>CategpryResposirtoy.cs and Another for iPerspositroy>ICategoryResporitory.cs 


Now Time is : 0600 And we willpush to Git Hub with This Readme Because i dont wanna lose another 1%:(


ITS 0648 NOW AND WE COMPLETED THE  2.2 mIGRATION AND HWAT SHOULD i tell it was tragic history 
how i idid it UnitOfwork and I unit and StartUp.cs error last one was really tricky to find out but anyways aleasat start from begining we did the 2.2.5 till everything was
good life of good times.....

We Created Two New Class Clases ISP_Call.cs And Sp_Call.cs
Add the content in with my typing all the code with comments in them 

here is theiSP_Call.cs


 mann Dapper Using System was something new 


Now in the Resporatiory>Sp_Call.cs Created 


This thing take the longest time to write mannnnnnn

After that we created new Interface IUnitOFWork.cs in Irepo

Here is code of the IuNit...



Simple 

After that we added new class of UnitOF work in the Repository Folder and now i got my Worst time 

  here is my code but instead ofthe   public class UnitOfWork : IUnitOfWork i did  public class UnitOfWork  because of which faced error number one then in startup.cs i just have to
add one line i thought it will be easy but no i added that line :     services.AddScoped<IUnitOfWork, UnitOfWork>(); 

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0311	The type 'AdityaBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 
'TImplementation' in the generic type or method 'ServiceCollectionServiceExtensions.AddScoped<TService,
TImplementation>(IServiceCollection)'. There is no implicit reference conversion from 
'AdityaBooks.DataAccess.Repository.UnitOfWork' to 'Abp.Domain.Uow.IUnitOfWork'.	AdityaBookStore	
C:\Users\W0835715\Source\Repos\AdityaBookStore_0835715\AdityaBookStore\Startup.cs	40	Active


but icant able to fiqure out the error then after words i did the using system thing in the this line by reviewing the lec slides....

Add updated the line with this code :       services.AddScoped<AdityaBooks.DataAccess.Repository.UnitOfWork, UnitOfWork>();

And now we have no error We are Happy Agian.....

Time : 0704
And now we will push Again third time a charm lets goooo Andrewwwwwwwwww............
time 0745

Now we will start the 2.3 Category Crud
 in this we will add the in Adminin the Controller the New Add Controller named CategoryController.cs
  We add the NEssercy using statments in them  and match the full code with sir file and now we will add new thing 

  In the View add the new Folder Category and in it add the new Razor View for index.cshtml and then copy pasted the code from the sir files 

  and runned the code  By the localhost...../Admin/Category

  in the views>shared>_layout.cshtml 

  we will update the command so that i dont have to use the typing in the url everytie and we add the Category in the drop down item list and it working good 

time 0807

In wwwroot /js We created the new file Called Category.js and added the code that sir provided and the in the index.cshtml we added this code to linkthem both and now we have the code r
running and how it suppose to look 

@section Scripts{ 

<script src="~/js/category.js"></script>
}

and after that the code was running good but instantlly i got back to code and it showed mt=e the sql.server excepetion 
After that i reliesed i have to update-database to let server know whats happeing 

in the CategoryController.cs we added the IAction Result for the Upsert vIew 

Time 0831

Did till Upsert View 
Saddddddddd


11/1/2023
time0410

Hello Sir We are back again lets see where we left off and we will countinue from there we did till the upsert view now we will add the new razor view forin the views > shared name _CreateAndBackToList 

Did the scaffholding and working good 


and now we type some codein the that creted folder and we will crete the buttons Submit back to list and similarly we 
will add a new _EditAndBackTolistButton
and we addeed this code in that 


And in the Upsert.cshtml we add the @model for it and now in the Index.cshtml we add some code such as 
 

                the index.cshtml we added the Asp-Action for Upsert runned the code 

Time 0623

Runned the code and it working correctly how it suppose to 
we are almost at the end hurrryyyyyyy

We use this url: local...../Admin/Category/Upsert

Change the tilte to the Edit Category

Now we created the the post method in the Upsert and didd to many thing with change we removed some save Commands from somne where and we add this command in some other palcsss

And in the Catergory Colloer We will Add the Code For the Delete is this :
    and affter that 
                       we will added below that this code which provided by the sir but i have to write it manually because we cant copy and paste 




And finally the moment of truth we will run the code at the ti e of 0820 and 


Sucessfulllyyyyyyyyyy runned 

We are done with the Assignment with Complete README at the Time of 


             **********************************************************    DATE: 11/1/2023  **********************************************************

                  ********************************************************** Time : 0821  **********************************************************

                                                                        Assignment - 2 Part THREE

 ****************************************************************************************************************************************************************

Date 15 October 2023
Time : 0534
3.1 CoverType Crud 

Started the Assignment 2 part three
First we will create the CoverType.cs In the Models Folder and We will add the nesseacrry class to it 
Which is ID and Name 
It will be same as the Category File and we will also addd the requiered Using statments 

now its time :5:50

Created the CoverTypeRepository.cs in Repository Folder 
 i did the Same coding as the Category Repository one just changed the name where it says the Category to Covertype 

 Same Goes with the ICoverTypeRepository 
 Did that Coding Also 
 
 Everything looking good till now 

 Add the Covertype Code in UnitofWork and iUnitOfWork 

Did really carefully did not want to mess up inthe typo 

and after that we also add the Database Code in the ApplicationContextDb



                                                 Time : 0622
                                                 Added the Migration and updated the database : PM> add-migration AddCoverTypeToDb

Also updated the Dataabse 

-Update-Databse 

Now We will perfom CRUD opreations 

In the View Folder We will go to Shared in _layout.cshtml

And add the Nav link in the DropDown Menu 

Created the CoverType Controller Where there was a Category Controller and Did All the Action Method in it 
it was hard but did it with the help of CategoryController.cs

Now We will add the View similar to Category in the Index.cshtml and Upsert.cshtml 
And Also Linked with The javaScript File 

and Created the javascript.js 

Checked the Code and now it all running good and perfect.

Now we will do the Products 

Add the Product Model in it 
Add the Code shown in the pptx

and also Updated the AppliconContectDb.cs
 Did the Miogration 


added the product Class and Also did the Migration 




                                             Time:6:40
                                             PM> add-migration AddproductToDb


Validation to product 



                                    Time : 6:45
                                    Migration: PM> add-migration AddValidationToProduct




Added the ProductRepositoy.cs and the Similar code as the Category nad CoverType and also did the IPRoductRepository 

Time:7:03

then we Did the UnitOFwork And i unt Of Work just added the 2 to3 line of code in both pretty simple 

Bulid and checked of any errors there were no error 


                            ****************************************************************************************************

                                                                   Assignemnt-2 part 3 section-2 

                            ****************************************************************************************************
Date:2023/11/16
Time 2:30PM

So were we left is we need to start the Section 2 today and aleast hope we will complete this today 
now we will check yesterdays code and run it again to see any bulid in error or anything we checked it and everything is looking good 

Now we will add the ProductControllers.cs
in the Area>Admin
And performe the CRUD opereations 

Created the Private IWebHostingEnviorment and mentioned the Using System satement for the Hosting in the First line.

Created the New Viewmodel in the ViewModel's Folder 
with the Name of ProductVM.cs

then Written the Code for the ProductVM.cs File as shown in the Ppptx

aftwer that got the Red line error in the SelectlistItem so we clicked on it and we will install the Microsoft.Mvc>ViewFeatures Package 

its time :3:23Pm

Modified the ProductController Action method to metioned the Upsert Calls and the ProductVM.cs add the Nesseacay Using system for the ViewModels and Rendering 

Commented the Upsert Post 

Modifed my API All in the GetAll Method and Mentioned the Category and coverType

Date:2023/11/16
time:3:45Pm

We will create the Add a new view From the ProductController.cs in the Index and right Clicked on it then we will Add the Razore view And select the path for it that will be to the 
_Layout.cshtmlCopied the Full code from the Category's index.html and and we will modifed it to according to the Public Class of the Product.cs

Did the that all and also created the Javascript File Foe the Product.js

Similarly We wil copy the Full code og the Category.js and we will the Three line code where it sayts category we will update to the product that it 

Now it time 4:01Pm

We had a Short Coffe Break and now we will do the layout.cshtml thing where the last drop down link reamining in which we will add the 
the last thing which the product index and updated the like that which was pretty easy as we added this things in the category and CoverType

Runned the Application 

And We got the Loding thing as it was shown and also when i runned the application it redirected me to the code and showed me the Sql.Exception 

So i tried to do the Migration again as we changed alot things in the code and we   



                    did the ,migration of --add-migration RemovedTheException



and updated the Database and sucessfull it runned and now the code is looking good again and we gor the no data thing so that a good sign 
i amhapppy

tried to do create table Create a product and iut was not working as we didnt do the Upsert

so lets jump into the Section 3

                                       ************************************************

                                            Assignment 2 Part_3 Section3

                                       ***********************************************

Time:4:15

Create The Upsert.cs For the Product added that 

The Code Was akready Provided by the Andrew which was really good but he told us in the Class there might be an error in the Upsert.cshtml so we will check later on that 

Created the Tiny.Cloud Account and got my API 

Time: 4:27PM




                                                 API KEY : ssvr9wwlivwvmz99qaqwdz7hzoj8wrimz3re9zy7yk7vl47s





 Added the 
 Sweet error thing in the Upsert.cshtml File As the Code was shown for it 
 just i used my Api key in that 

 Runned the Application And Unforunetly i got the exception when i try to add the data and also one more thing my Covertye and Category Data is the Same i dont know why we have to check that also and 
 one more thing i think i messed up badly in the Data tabe because it was showing me i have conflict in the table Frogiren Key All let me 
 get back into that when i will find the Error 

 Time; 4:47Pm

 Just found the Error after checking my all files it suckssssss really 
 the error was in the Upsert.cshmtl where There was mentioned of the Category in the CoverType 

 Thats why we got the Error hhhhhhhhh!

 NOW WE WILL dO THE REMAINING STEPS 

 Just added the New Folder And subFolder inthe wwwroot thing 
 Images>Product

 Now we configure the Product Post upsert action method where we uncommented the Upsert code that was commented in thr Section 2

 We checked for the Errors and Runned the Application and its shows all the Data when i put it in and also Give me the Sweet Alert when i dont insert the Image in that

 Everything is done PRoperly incluidng the Readme 

Date : 2023/11/16
Time: 5:42PM

Assignment is Completed 

Hurryyyyyyyyyy!

             **********************************************************    DATE 2023/11/21  **********************************************************

                  ********************************************************** Time : 0316  **********************************************************

                                                                        Assignment - 2 Part Four

 ****************************************************************************************************************************************************************

Date 2023 November 21st
Time : 0316


Hello Sir, here we are again in the last part of the assignment right now my assignment is working completely with the product is shown in the DATABASE WITH THe enties are also showned in the table successfully without any
error 

So thats a good thing 

Time3:30

hello again now we will look the full code of the sir provided Github a=link and figure it out how to add the the image and all in the home of mine it should be near homecontroller but we will see from 
here code lets go and check it 

Checked the code and looked at it and also checked evert=yother thing so that i am not missing anything in the end we checked the homecontrollers index file need be edited which i did 
and i n the View Index.cshtml also need to be changed which we will do it now 

Added that full code changed the requiered statmenets and removed the errorss in it and now i think i am ready to see the image but let me add the image in the last folder  we created in the www folder in the

We downloded the image from the internet and added in that folder 

now we will run it 

but we got the exception 
 let me check the code again 

 Time : 4:15

 GOT THE error 
 thats not kind off an error its just i am missing bit of a chuck code in the ProductController.cs file 
so we will add that 

Time : 4:34

Added the code and removed the error and during this time also found another file which is upsert.cshtml we need to add the imageURl

So we added the Productcontroller.cs / Upsert.cs

So now we will try to add again and it 

Date: 2023-11-21
time : 5:06

Lets check it and we got what we wannted in the first place and now i am happy and we will push this thing to github 

Now we will attand the Modays lecture and check it if andwer needs anyother thing than this if he need then we will come back on Monday 
Thank you 