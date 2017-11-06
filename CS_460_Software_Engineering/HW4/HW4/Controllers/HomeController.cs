﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html5;
using HW4.Models;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Page1()
        {
            return View();
        }


        public ActionResult Page1Result()
        {
            int nextAge = 0;
            bool birthdayToday = false;
            string ageEnding = "";
            string nextAgeString = "";
            int finalDigit = 0;
            int daysUntil = 0;
            string firstname = Request.QueryString["firstname"].ToString();

            DateTime today = DateTime.Today;

            int year = Int32.Parse(Request.QueryString["year"].ToString());
            int month = Int32.Parse(Request.QueryString["month"].ToString());
            int day = Int32.Parse(Request.QueryString["day"].ToString());

            if (month == 2 && day == 29 && !DateTime.IsLeapYear(today.Year))
            {
                int pastYears = today.Year;
                birthdayToday = false;
                nextAge = 1;

                while (pastYears > year)
                {
                    if (DateTime.IsLeapYear(pastYears))
                    {
                        nextAge += 1;
                    }

                    pastYears -= 1;
                }
            }
            else
            {
                DateTime birthdayThisYear = new DateTime(today.Year, month, day);

                if (birthdayThisYear.CompareTo(today) >= 0)
                {
                    nextAge = today.Year - year;

                    if (birthdayThisYear.CompareTo(today) == 0)
                    {
                        birthdayToday = true;
                    }
                    else
                    {
                        birthdayToday = false;
                    }
                }
                else
                {
                    nextAge = (today.Year - year) + 1;
                    birthdayToday = false;
                }
            }

            if (birthdayToday == false)
            {
                int monthIndex = today.Month;
                int yearIndex = today.Year;

                if (month == 2 && day == 29)
                {
                    while (monthIndex != month || !DateTime.IsLeapYear(yearIndex))
                    {
                        if (yearIndex == today.Year && monthIndex == today.Month)
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex) - today.Day;
                        }
                        else
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex);
                        }

                        if (monthIndex == 12)
                        {
                            monthIndex = 1;
                            yearIndex += 1;
                        }
                        else
                        {
                            monthIndex += 1;
                        }
                    }
                }
                else
                {
                    while (monthIndex != month)
                    {
                        if (yearIndex == today.Year && monthIndex == today.Month)
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex) - today.Day;
                        }
                        else
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex);
                        }

                        if (monthIndex == 12)
                        {
                            monthIndex = 1;
                            yearIndex += 1;
                        }
                        else
                        {
                            monthIndex += 1;
                        }
                    }
                }

                if (daysUntil > 0)
                {
                    daysUntil += day;
                }
                else
                {
                    daysUntil = day - today.Day;
                }
            }

            ageEnding = nextAge.ToString();

            if (ageEnding.Length > 1 && ageEnding.Substring((ageEnding.Length - 2), 1) == "1")
            {
                ageEnding = "0";
            }
            else
            {
                ageEnding = ageEnding.Substring(ageEnding.Length - 1);
            }

            finalDigit = Int32.Parse(ageEnding);

            if (finalDigit == 1)
            {
                ageEnding = "st";
            }
            else if (finalDigit == 2)
            {
                ageEnding = "nd";
            }
            else if (finalDigit == 3)
            {
                ageEnding = "rd";
            }
            else
            {
                ageEnding = "th";
            }

            nextAgeString = nextAge.ToString() + ageEnding;

            if (birthdayToday)
            {
                if (year == today.Year)
                {
                    ViewBag.Message = "You were born today. You're just getting started, " + firstname + "!";
                }
                else
                {
                    ViewBag.Message = "It's your " + nextAgeString + " birthday today, " + firstname + ". Well, happy birthday!";
                }
            }
            else
            {
                ViewBag.Message = "There are " + daysUntil + " days until your " + nextAgeString + " birthday, " + firstname + ".";
            }

            return View();
        }

        [HttpGet]
        public ActionResult Page2()
        {
            ViewBag.RequestMethod = "GET";
            return View();
        }

        [HttpPost]
        public ActionResult Page2(FormCollection form)
        {
            ViewBag.RequestMethod = "POST";
            int nextAge = 0;
            bool birthdayToday = false;
            string ageEnding = "";
            string nextAgeString = "";
            int finalDigit = 0;
            int daysUntil = 0;

            DateTime today = DateTime.Today;

            int year = Int32.Parse(form["year"]);
            int month = Int32.Parse(form["month"]);
            int day = Int32.Parse(form["day"]);

            if (month == 2 && day == 29 && !DateTime.IsLeapYear(today.Year))
            {
                int pastYears = today.Year;
                birthdayToday = false;
                nextAge = 1;

                while (pastYears > year)
                {
                    if (DateTime.IsLeapYear(pastYears))
                    {
                        nextAge += 1;
                    }

                    pastYears -= 1;
                }
            }
            else
            {
                DateTime birthdayThisYear = new DateTime(today.Year, month, day);

                if (birthdayThisYear.CompareTo(today) >= 0)
                {
                    nextAge = today.Year - year;

                    if (birthdayThisYear.CompareTo(today) == 0)
                    {
                        birthdayToday = true;
                    }
                    else
                    {
                        birthdayToday = false;
                    }
                }
                else
                {
                    nextAge = (today.Year - year) + 1;
                    birthdayToday = false;
                }
            }

            if (birthdayToday == false)
            {
                int monthIndex = today.Month;
                int yearIndex = today.Year;

                if (month == 2 && day == 29)
                {
                    while (monthIndex != month || !DateTime.IsLeapYear(yearIndex))
                    {
                        if (yearIndex == today.Year && monthIndex == today.Month)
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex) - today.Day;
                        }
                        else
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex);
                        }

                        if (monthIndex == 12)
                        {
                            monthIndex = 1;
                            yearIndex += 1;
                        }
                        else
                        {
                            monthIndex += 1;
                        }
                    }
                }
                else
                {
                    while (monthIndex != month)
                    {
                        if (yearIndex == today.Year && monthIndex == today.Month)
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex) - today.Day;
                        }
                        else
                        {
                            daysUntil += DateTime.DaysInMonth(yearIndex, monthIndex);
                        }

                        if (monthIndex == 12)
                        {
                            monthIndex = 1;
                            yearIndex += 1;
                        }
                        else
                        {
                            monthIndex += 1;
                        }
                    }
                }

                if (daysUntil > 0)
                {
                    daysUntil += day;
                }
                else
                {
                    daysUntil = day - today.Day;
                }
            }

            ageEnding = nextAge.ToString();

            if (ageEnding.Length > 1 && ageEnding.Substring((ageEnding.Length - 2), 1) == "1")
            {
                ageEnding = "0";
            }
            else
            {
                ageEnding = ageEnding.Substring(ageEnding.Length - 1);
            }

            finalDigit = Int32.Parse(ageEnding);

            if (finalDigit == 1)
            {
                ageEnding = "st";
            }
            else if (finalDigit == 2)
            {
                ageEnding = "nd";
            }
            else if (finalDigit == 3)
            {
                ageEnding = "rd";
            }
            else
            {
                ageEnding = "th";
            }

            nextAgeString = nextAge.ToString() + ageEnding;

            if (birthdayToday)
            {
                if (year == today.Year)
                {
                    ViewBag.Message = "You were born today. You're just getting started, " + form["firstname"] + "!";
                }
                else
                {
                    ViewBag.Message = "It's your " + nextAgeString + " birthday today, " + form["firstname"] + ". Well, happy birthday!";
                }
            }
            else
            {
                ViewBag.Message = "There are " + daysUntil + " days until your " + nextAgeString + " birthday, " + form["firstname"] + ".";
            }

            return View();
        }

        public ActionResult Page3()
        {
            return View(new InvestmentCalculator());
        }

        [HttpPost]
        public ActionResult Page3(InvestmentCalculator c)
        {
            double total = Math.Round(c.Principle, 2);
            double n = c.Term * c.Time;
            double interest = c.Interest / 100;
            double totalEarned = 0;
            string interestType = "";
            string termString = "";
            string yearString = "";

            if(c.Time == 1)
            {
                yearString = " year";
            }
            else
            {
                yearString = " years";
            }

            if(c.Term == 365)
            {
                termString = "daily";
            }
            else if(c.Term == 52)
            {
                termString = "weekly";
            }
            else if(c.Term == 12)
            {
                termString = "monthly";
            }
            else
            {
                termString = "annually";
            }

            if(c.Compound)
            {
                totalEarned = Math.Round((c.Principle * Math.Pow((1 + interest), n) - c.Principle), 2);
                interestType = " compounded ";
            }
            else
            {
                totalEarned = Math.Round((c.Principle * interest * n), 2);
                interestType = " calculated ";
            }

            total += totalEarned;

            ViewBag.Message = "An investment of $" + Math.Round(c.Principle, 2) + " with a " + c.Interest + "% interest rate " + interestType + termString + " over " + c.Time + yearString + " would earn $" + totalEarned + " for a total ending balance of $" + total + ".";

            return View("Page3Result", "~/Views/Shared/_Layout.cshtml", ViewBag.Message);
        }

        public ActionResult Page3Result(string m)
        {
            ViewBag.Message = m;

            return View();
        }
    }
}