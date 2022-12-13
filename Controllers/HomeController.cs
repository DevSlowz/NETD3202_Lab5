using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETD3202_Lab5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

/*
 *  Name: Matthew Vieira
 *  Date: 2022-12-12
 *  Description: This program is collects user input to store recipes 
 *
 */
namespace NETD3202_Lab5.Controllers
{

    public class HomeController : Controller
    {
        public List<recipe> recipeList = new List<recipe>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Appraise()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Appraise(recipe recipes)
        {
            string message = "";
            double price = 0;
            // Check Input To Ensure it is Valid
            if (ModelState.IsValid)
            {
                //// If valid display view and display the price of the textbook.
                //ViewData["Message"] = "Textbook: " + recipe.title + "\r\n Version: " + recipe.version + "\n ISBN: " +
                //                      recipe.isbn + "\n Condition: " + recipe.condition;

                //price = recipe.calculatePrice(recipe.condition, textbook.price);
                //ViewData["AppraisedPrice"] = "Appraised Price: $" + price;

                //// Add textbook to global list of textbooks.
                //textbooks.Add(new Textbook(textbook.title, textbook.isbn, textbook.version, textbook.price, textbook.condition));


                //return View("ViewAppraisal", textbook);

            }
            else
            {
                // If invalid display view and display an error message
                ViewData["Message"] = "Invalid Entry please check your inputs and try again.";
                return View("FailureScreen");
            }
        }


        public IActionResult ViewAllAppraisals(List<recipe> recipes)
        {
            // print all textbooks in the list
            //List<Textbook> coolTextbooks = new List<Textbook>();
            //coolTextbooks.AddRange(textbooks);
            List<recipe> recipesList = new List<recipe>()
            {
                new recipe()
                {
   
                },
                new recipe()
                {

                }
            };

            ViewBag.books = recipesList;
            ViewData["Message"] = recipes;

            return View("ViewAllRecipes", recipes);

        }


    }
}
