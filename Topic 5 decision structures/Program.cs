namespace Topic_5_decision_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //damon 
            string answer;
            Console.WriteLine("Would you like to use the bank or the parking garage?");
            answer = Console.ReadLine().ToLower();
            
            if (answer == "the bank" )
            {
                BlorbianBank();
            }
            else if (answer =="parking garage")
            {
                ParkingGarage();
            }
        static void ParkingGarage()
        {
            Console.WriteLine("How was your stay at Ethan's parking garage!");
            Thread.Sleep(2000);
            Console.WriteLine("That's great to hear! How long was your stay? our system only takes the time in minutes!");
            ParkingTime();



        }
        static void ParkingTime()
        {
            double parkingTime;
            parkingTime = Convert.ToDouble(Console.ReadLine());
            if (parkingTime < 60)
            {
                Console.WriteLine("You will be charged $4 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime < 120 && parkingTime > 60)
            {
                Console.WriteLine("You will be charged $6 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime < 180 && parkingTime > 120)
            {
                Console.WriteLine("You will be charged $8 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime < 240 && parkingTime > 180)
            {
                Console.WriteLine("You will be charged $10 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime < 300 && parkingTime > 240)
            {
                Console.WriteLine("You will be charged $12 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime < 360 && parkingTime > 300)
            {
                Console.WriteLine("You will be charged $14 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime < 420 && parkingTime > 360)
            {
                Console.WriteLine("You will be charged $16 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime < 480 && parkingTime > 420)
            {
                Console.WriteLine("You will be charged $18 for the " + parkingTime + " minutes you stayed!");
            }
            else if (parkingTime > 480)
            {
                Console.WriteLine("You will be charged $20 for the " + parkingTime + " minutes you stayed!");
            }
        }
            static void BlorbianBank()
            {
                string transaction;
                double money, deposit, withdrawl;
                money = 150;
                Console.WriteLine("Welcome to the Bank of Blorb! Would you like to \nDeposit \nWithdrawl \nPay a Bill \nSee account balance \nExit");
                Console.WriteLine("Transaction fees will apply to any option including exiting! Please type the option you would like to choose.");
                transaction = Console.ReadLine().ToLower();
                if (transaction == "exit")
                {
                    money = money - 0.75;
                    Console.WriteLine("You now have $" + money + " left in your account! Goodbye!");
                }
                else if (transaction == "deposit")
                {
                    money = money - 0.75;
                    Console.WriteLine("Please enter the amount you would like to deposit!");
                    deposit = Convert.ToDouble(Console.ReadLine());
                    if (deposit < 0)
                    {
                        Console.WriteLine("You can not deposit a negative number. Please try again.");
                        deposit = Convert.ToDouble(Console.ReadLine());
                        money = money + deposit;
                        Console.WriteLine("OK! Your new account balance is $" + money);
                    }
                    else
                    {
                        money = money + deposit;
                        Console.WriteLine("OK! Your new account balance is $" + money);
                    }

                }
                else if (transaction == "withdrawl")
                {
                    money = money - 0.75;
                    Console.WriteLine("You currently have $" + money + "! How much would you like to withdrawl?");
                    withdrawl = Convert.ToDouble(Console.ReadLine());
                    if (withdrawl < 0)
                    {
                        Console.WriteLine("Please keep it positive numbers please.");
                        withdrawl = Convert.ToDouble(Console.ReadLine());


                    }
                    else if (withdrawl < money)
                    {
                        money = money - withdrawl;
                        Console.WriteLine("You took out $" + withdrawl + "! You now have $" + money + " left!");
                    }
                    else if (withdrawl > money)
                    {
                        bool done = false;
                        if (withdrawl > money)
                        {
                            done = false;
                        }
                        else if (withdrawl < money)
                        {
                            done = true;
                        }
                        while (!done)
                        {
                            Console.WriteLine("You do not have that much money please enter a valid value.");
                            withdrawl = Convert.ToDouble(Console.ReadLine());
                            money = money - withdrawl;
                            Console.WriteLine("You took out $" + withdrawl + "! You now have $" + money + " left!");
                        }
                    }
                }
           
               
                else if (transaction == "pay a bill")
                {
                    money = money - .75;
                    Console.WriteLine("You currently have $" + money + "! How much is the bill?");
                    withdrawl = Convert.ToDouble(Console.ReadLine());
                    if (withdrawl < 0)
                    {
                        Console.WriteLine("Please keep it positive numbers please.");
                        withdrawl = Convert.ToDouble(Console.ReadLine());
                        money = money - withdrawl;
                        Console.WriteLine("The bill was $" + withdrawl + "! You now have $" + money);
                    }
                    else if (withdrawl < money)
                    {
                        money = money - withdrawl;
                        Console.WriteLine("The bill was $" + withdrawl + "! You now have $" + money);
                    }
                    else if (withdrawl > money)
                    {
                        Console.WriteLine("You do not have that much money! Please come back when you have enough");
                    }

                }
                else if (transaction == "see account balance")
                {
                    money = money - 0.75;
                    Console.WriteLine("You currently have $" + money + " left in your account!");
                }
            }
        }
    }

    }
