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

  public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }
    }

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


