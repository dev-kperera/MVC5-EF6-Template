/*
 ASP.NET MVC template using Code First Approach
 * 2016, @kushanlahiru
 */
using System.Data.Entity.Infrastructure;
namespace MVCPlayGround
{
    class ReadMe
    {
        //TODO:[5] Edit connection string in the Web.config in the "AppSettings" section
        #region Guide to connection string configuration
        //Include LocalDb for developement purposes in the App_Data

        //Else change connection string to production database 
        #endregion


        //TODO:[6] Crete the controllers and scafold views
        //create controller using "MVC5 Controller with views using Entity Framework"
        //Note: Remove unwanted controllers generated

        //TODO:[7] Configure RouteConfig.cs; if required

        //TODO:[Final] Manipulate Views and _Layout.cshtmls; if required

        // Other Notes
        #region When Working with controllers 

         ///Use below when checking for exceptions in controller 
         //try
         //   {
         //       //Your update logic here 
         //   }
         //   catch (RetryLimitExceededException /* dex */)
         //   {
         //       //Log the error (uncomment dex variable name and add a line here to write a log.
         //       ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
         //   }

        //Sorting
        //Sorting can be achieved in controllers by using LINQ

        //Search..by passing parameter to controller and LINQ..can achieve this
        // if (!String.IsNullOrEmpty(searchString))    {
        //students = students.Where(s =>s.LastName.ToUpper().Contains(searchString.ToUpper())                    
        //s.FirstMidName.ToUpper().Contains(searchString.ToUpper()));    }

        //Paging
        //Install PagedList.Mvc nuget package

        //Following package manager commands are useful when working with EF
        //PM>enable-migrations
        //PM>add-migration initial 
        //PM>update-database

        //Update for other than first time
        //PM>add-migration 
        //PM>update-database
	



        #endregion


    }
}