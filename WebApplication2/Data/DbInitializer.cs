using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication2.Models;
using WebApplication2.Data;

namespace WebApplication2.Data
{
    public static class DbIntializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree already exists");
            }
            else
            {
                var degrees = new Degree[]
                {
                    new Degree{DegreeId = 1, DegreeAbrrev="ACS+2", DegreeName = "MS ACS+2"},
                    new Degree{DegreeId = 2, DegreeAbrrev="ACS+DB", DegreeName = "MS ACS+DB"},
                    new Degree{DegreeId = 3, DegreeAbrrev="ACS+NF", DegreeName = "MS ACS+NF"},
                    new Degree{DegreeId = 4, DegreeAbrrev="ACS", DegreeName = "MS ACS"},

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }

                context.SaveChanges();
            }


            //Credit table
            if (context.Credits.Any())
            {
                Console.WriteLine("Credit already exists");
            }
            else
            {
                var credits = new Credit[]
                {
                    new Credit{CreditId = 460, CreditAbrrev="DB", CreditName = "Databases", isSummer = 0, isSpring=1, isFall=1, DegreeId=1},
                    new Credit{CreditId = 356, CreditAbrrev="NF", CreditName = "Network Fundamentals", isSummer = 0, isSpring=1, isFall=1, DegreeId=1},
                    new Credit{CreditId = 542, CreditAbrrev="542-OOP", CreditName = "OOP with Java", isSummer = 0, isSpring=1, isFall=1, DegreeId=1},
                    new Credit{CreditId = 563, CreditAbrrev="563-Web", CreditName = "Web Apps", isSummer = 0, isSpring=1, isFall=1, DegreeId=1},
                    new Credit{CreditId = 560, CreditAbrrev="560-ADB", CreditName = "Advanced Databases", isSummer = 1, isSpring=1, isFall=1, DegreeId=1},
                    new Credit{CreditId = 664, CreditAbrrev="664-UX", CreditName = "User Experience", isSummer = 0, isSpring=1, isFall=1,DegreeId=1},
                    new Credit{CreditId = 618, CreditAbrrev="618-PM", CreditName = "Project Management", isSummer = 1, isSpring=0, isFall=0, DegreeId=1},
                    new Credit{CreditId = 555, CreditAbrrev="555-NS", CreditName = "Network Security", isSummer = 0, isSpring=1, isFall=1,DegreeId=1},
                    new Credit{CreditId = 691, CreditAbrrev="691-GDP1", CreditName = "GDP1", isSummer = 1, isSpring=1, isFall=1,DegreeId=1},
                    new Credit{CreditId = 692, CreditAbrrev="692-GDP2", CreditName = "GDP2", isSummer = 0, isSpring=1, isFall=1,DegreeId=1},
                    new Credit{CreditId = 643, CreditAbrrev="643-Android", CreditName = "Android", isSummer = 0, isSpring=1, isFall=1,DegreeId=1},
                    new Credit{CreditId = 10, CreditAbrrev="E1", CreditName = "Elective1", isSummer = 0, isSpring=1, isFall=1,DegreeId=1},
                    new Credit{CreditId = 20, CreditAbrrev="E2", CreditName = "Elective2", isSummer = 0, isSpring=1, isFall=1,DegreeId=1},
                    new Credit{CreditId = 644, CreditAbrrev="IOS", CreditName = "IOS", isSummer = 0, isSpring=1, isFall=1,DegreeId=1}


                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");

                foreach (Credit c in credits)
                {
                    context.Credits.Add(c);
                }

                context.SaveChanges();
            }

            //Student table
            if (context.Students.Any())
            {
                Console.WriteLine("Student already exists");
            }
            else
            {
                var students = new Student[]
                {
                    new Student{StudentId = 533569, FamilyName="Chetty Ragava", GivenName = "Harshitha", Snumber = 533569, Num919 = 919568034},
                    new Student{StudentId = 533982, FamilyName="Ali", GivenName = "Zaiba", Snumber = 533982, Num919 = 919569110},
                    new Student{StudentId = 533573, FamilyName="Nuka", GivenName = "Vamshi krishna", Snumber = 533573, Num919 = 919570332}

                };
                Console.WriteLine($"Inserted {students.Length} new students.");

                foreach (Student st in students)
                {
                    context.Students.Add(st);
                }

                context.SaveChanges();
            }

            //DegreeCredit table
            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredit already exists");
            }
            else
            {
                var degreeCredits = new DegreeCredit[]
                {
                    new DegreeCredit{DegreeCreditId = 1, DegreeId=3, CreditId = 460},
                    new DegreeCredit{DegreeCreditId = 2, DegreeId=3,   CreditId  = 356},
                    new DegreeCredit{DegreeCreditId = 3,  DegreeId=3,  CreditId  = 542},
                    new DegreeCredit{DegreeCreditId = 4,  DegreeId=3,  CreditId  = 563},
                    new DegreeCredit{DegreeCreditId = 5,  DegreeId=3,  CreditId  = 560},
                    new DegreeCredit{DegreeCreditId = 6, DegreeId=3,  CreditId = 664 },
                    new DegreeCredit{DegreeCreditId = 7, DegreeId=3, CreditId = 618},
                    new DegreeCredit{DegreeCreditId = 8, DegreeId=3,   CreditId  = 555},
                    new DegreeCredit{DegreeCreditId = 9,  DegreeId=3,  CreditId  = 691},
                    new DegreeCredit{DegreeCreditId = 10,  DegreeId=3,  CreditId  = 692},
                    new DegreeCredit{DegreeCreditId = 11,  DegreeId=3,  CreditId  = 643},
                    new DegreeCredit{DegreeCreditId = 12, DegreeId=3,  CreditId = 10 },
                    new DegreeCredit{DegreeCreditId = 13, DegreeId=3, CreditId = 20},
                    new DegreeCredit{DegreeCreditId = 14, DegreeId=3,   CreditId  = 460},
                    new DegreeCredit{DegreeCreditId = 15,  DegreeId=3,  CreditId  = 542},
                    new DegreeCredit{DegreeCreditId = 16,  DegreeId=3,  CreditId  = 563},
                    new DegreeCredit{DegreeCreditId = 17,  DegreeId=3,  CreditId  = 560},
                    new DegreeCredit{DegreeCreditId = 18, DegreeId=3,  CreditId = 664 },
                    new DegreeCredit{DegreeCreditId = 19, DegreeId=3, CreditId = 618},
                    new DegreeCredit{DegreeCreditId = 20, DegreeId=3,   CreditId  = 555},
                    new DegreeCredit{DegreeCreditId = 21,  DegreeId=3,  CreditId  = 691},
                    new DegreeCredit{DegreeCreditId = 22,  DegreeId=3,  CreditId  = 692},
                    new DegreeCredit{DegreeCreditId = 23,  DegreeId=3,  CreditId  = 643},
                    new DegreeCredit{DegreeCreditId = 24, DegreeId=3, CreditId = 10},
                    new DegreeCredit{DegreeCreditId = 25, DegreeId=3,   CreditId  = 20},
                    new DegreeCredit{DegreeCreditId = 26,  DegreeId=3,  CreditId  = 356},
                    new DegreeCredit{DegreeCreditId = 27,  DegreeId=3,  CreditId  = 542},
                    new DegreeCredit{DegreeCreditId = 28,  DegreeId=3,  CreditId  = 563},
                    new DegreeCredit{DegreeCreditId = 29, DegreeId=3,  CreditId = 560 },
                    new DegreeCredit{DegreeCreditId = 30, DegreeId=3, CreditId = 664},
                    new DegreeCredit{DegreeCreditId = 31, DegreeId=3,   CreditId  = 618},
                    new DegreeCredit{DegreeCreditId = 32,  DegreeId=3,  CreditId  = 555},
                    new DegreeCredit{DegreeCreditId = 33,  DegreeId=3,  CreditId  = 691},
                    new DegreeCredit{DegreeCreditId = 34,  DegreeId=3,  CreditId  = 692},
                    new DegreeCredit{DegreeCreditId = 35, DegreeId=3,  CreditId = 643 },
                    new DegreeCredit{DegreeCreditId = 36, DegreeId=3, CreditId = 10},
                    new DegreeCredit{DegreeCreditId = 37, DegreeId=3,   CreditId  = 20},
                    new DegreeCredit{DegreeCreditId = 38,  DegreeId=3,  CreditId  = 542},
                    new DegreeCredit{DegreeCreditId = 39,  DegreeId=3,  CreditId  = 563},
                    new DegreeCredit{DegreeCreditId = 40,  DegreeId=3,  CreditId  = 560},
                    new DegreeCredit{DegreeCreditId = 41, DegreeId=3,  CreditId = 664},
                    new DegreeCredit{DegreeCreditId = 42,  DegreeId=3,  CreditId  = 618},
                    new DegreeCredit{DegreeCreditId = 43, DegreeId=3,  CreditId = 555 },
                    new DegreeCredit{DegreeCreditId = 44,  DegreeId=3,  CreditId  = 691},
                    new DegreeCredit{DegreeCreditId = 45, DegreeId=3,  CreditId = 692},
                    new DegreeCredit{DegreeCreditId = 46,  DegreeId=3,  CreditId  = 644},
                    new DegreeCredit{DegreeCreditId = 47, DegreeId=3,  CreditId = 10 },
                    new DegreeCredit{DegreeCreditId = 48,  DegreeId=3,  CreditId  = 20}
                };
                Console.WriteLine($"Inserted {degreeCredits.Length} new degreecredit.");

                foreach (DegreeCredit d in degreeCredits)
                {
                    context.DegreeCredits.Add(d);
                }

                context.SaveChanges();
            }

            //Degreeplan table
            if (context.DegreePlans.Any())
            {
                Console.WriteLine("DegreePlan already exists");
            }
            else
            {
                var degreeplans = new DegreePlan[]
                {
                    new DegreePlan{DegreePlanId = 7251, StudentId=533569, DegreePlanAbbrev = "Super", DegreePlanName="As",DegreeId=3},
                    new DegreePlan{DegreePlanId = 7252, StudentId=533569, DegreePlanAbbrev = "Slow", DegreePlanName="Take",DegreeId=3},
                    new DegreePlan{DegreePlanId = 7253, StudentId=533982, DegreePlanAbbrev = "Easy", DegreePlanName="Study",DegreeId=3},
                    new DegreePlan{DegreePlanId = 7254, StudentId=533982, DegreePlanAbbrev = "one", DegreePlanName="Complete",DegreeId=3},
                    new DegreePlan{DegreePlanId = 7255, StudentId=533573, DegreePlanAbbrev = "slow", DegreePlanName="Maximum",DegreeId=3},
                    new DegreePlan{DegreePlanId = 7256, StudentId=533573, DegreePlanAbbrev = "Default", DegreePlanName="Default",DegreeId=3}

                };
                Console.WriteLine($"Inserted {degreeplans.Length} new degreeplans.");

                foreach (DegreePlan dp in degreeplans)
                {
                    context.DegreePlans.Add(dp);
                }

                context.SaveChanges();
            }

            //Slot table
            if (context.Slots.Any())
            {
                Console.WriteLine("Slot already exists");
            }
            else
            {
                var slots = new Slot[]
                {
                    new Slot {SlotId=1,DegreePlanId=7251,StudentTermId=1,CreditId=542,Status="C"}
                };
                Console.WriteLine($"Inserted {slots.Length} new slots.");

                foreach (Slot sl in slots)
                {
                    context.Slots.Add(sl);
                }

                context.SaveChanges();
            }

            

            //StudentTerm Table
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Term already exists");
            }
            else
            {
                var studentTerms = new StudentTerm[]
                {
                    new StudentTerm{StudentTermId = 1, StudentId=533569, StudentTermNo = 1, DegreePlanId = 7251, TermAbbrev="F18", TermName="Fall 2018"}
                };
                Console.WriteLine($"Inserted {studentTerms.Length} new studentTerms.");

                foreach (StudentTerm stt in studentTerms)
                {
                    context.StudentTerms.Add(stt);
                }

                context.SaveChanges();
            }  
        }
    }
}