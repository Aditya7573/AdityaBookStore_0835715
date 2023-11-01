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


****************** 2.2 REPOSITORY *******************

its 0552 

Till Nowi am on the Half of the @.2 Repository it was really like a roller coster ..... omggggg

let me explain what i did in past 30,min

 We created the new folder Repository in the DataAccess project and then in the repository dierctory i create new directory called iRepo 
  then in Ireposiroty.Cs we updated the Full Code to this

  that was given in by the sir in the pptx file 

  using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;



namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
       );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
       );

        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}

then we add the interface in the Repository.cs and the whole code was generated byit self but we didnt use that sir provided us with the filein assignment-2 folder we used that insteatdd ofthe whole code and 
in between all theese therewas a lot of Using system statement was added and revomed by the use which was not described in the pptx.

Then We created two new .cs File One For Repository>CategpryResposirtoy.cs and Another for iPerspositroy>ICategoryResporitory.cs 

iCategoryRepos.cs File : using System;
using System.Collections.Generic;
using System.Text;
using AdityaBooks.Models;

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}


CategoryRepo.cs File : 
using AdityaBooks.DataAccess.Repository.IRepository;
using AdityaBooks.Models;
using AdityaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdityaBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                //_db.SaveChanges();
            }
        }
    }
}

Now Time is : 0600 And we willpush to Git Hub with This Readme Because i dont wanna lose another 1%:(


ITS 0648 NOW AND WE COMPLETED THE  2.2 mIGRATION AND HWAT SHOULD i tell it was tragic history 
how i idid it UnitOfwork and I unit and StartUp.cs error last one was really tricky to find out but anyways aleasat start from begining we did the 2.2.5 till everything was
good life of good times.....

We Created Two New Class Clases ISP_Call.cs And Sp_Call.cs
Add the content in with my typing all the code with comments in them 

here is theiSP_Call.cs

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        // e.g first coloumn of first row in the result set 
        T Single<T>(string procedurename, DynamicParameters param = null);
        // excecute something to the data bt not retrieeve anything
        void Execute(string procedurename, DynamicParameters param = null);
        // reterive the complete row or record 
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        // get all the rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        // Stored Proccedure that reture two tables 
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}

 mann Dapper Using System was something new 


Now in the Resporatiory>Sp_Call.cs Created 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdityaBooks.DataAccess.Repository.IRepository;
using AdityaBookStore.DataAccess.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdityaBooks.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = "";

        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Execute(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var result = SqlMapper.QueryMultiple(sqlCon, procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
                var item1 = result.Read<T1>().ToList();
                var item2 = result.Read<T2>().ToList();


                if (item1 != null && item2 != null)
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(item1, item2);
                }
            }

            return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(new List<T1>(), new List<T2>());
        }

        public T OneRecord<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var value = sqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
                return (T)Convert.ChangeType(value.FirstOrDefault(), typeof(T));
            }
        }

        public T Single<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }
    }
}


This thing take the longest time to write mannnnnnn

After that we created new Interface IUnitOFWork.cs in Irepo

Here is code of the IuNit...


using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }

    }
}


Simple 

After that we added new class of UnitOF work in the Repository Folder and now i got my Worst time 

using System;
using System.Collections.Generic;
using System.Text;
using AdityaBooks.DataAccess.Repository.IRepository;
using AdityaBookStore.DataAccess.Data;
using System.Linq;



namespace AdityaBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);

            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}  here is my code but instead ofthe   public class UnitOfWork : IUnitOfWork i did  public class UnitOfWork  because of which faced error number one then in startup.cs i just have to
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

time 0807
time 0745



Time 0831

Did till Upsert View 
Saddddddddd