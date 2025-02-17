using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Name: Samuel Cable
    Description: Prints out information regarding salemen and demonstrates inheritance. 
    Tools used: Weekly courses info.

*/

public class Salesperson
{
    public string firstName;
    public string lastName;

    public string FullName()
    {
        return firstName + " " + lastName;
    }
}

//commission
public class RealEstateSalesperson : Salesperson
{
    public int soldAmt = 0;
    public int totCommissionEarned = 0;
    public int commissionRate = 0;
}

public class GirlScout : Salesperson
{
    public int cookiesSold = 0;
}

class Program
{
    public static void Main(string[] args)
    {
        GirlScout myGirlScout = new GirlScout();
        RealEstateSalesperson myRealSalesman = new RealEstateSalesperson();
        Salesperson mySalesP = new Salesperson();

        //Salesperson
        mySalesP.firstName = "Samuel";
        mySalesP.lastName = "David";
        Console.WriteLine("The Salesperson's full name is: " + mySalesP.FullName());

        //Girl scout
        myGirlScout.firstName = "Sara";
        myGirlScout.lastName = "Spalding";
        myGirlScout.cookiesSold = 4;
        Console.WriteLine("The Girl Scout's full name is: " + myGirlScout.FullName());
        Console.WriteLine("The Girl Scout's cookies sold: " + myGirlScout.cookiesSold);

        //RealSales
        myRealSalesman.firstName = "Stephen";
        myRealSalesman.lastName = "Seagal";
        myRealSalesman.soldAmt = 5;
        myRealSalesman.totCommissionEarned = 65;
        myRealSalesman.commissionRate = 44;

        string r = "The Real Estate Salesman's ";
        Console.WriteLine("The Real Estate Salesman's full name is: " + myRealSalesman.FullName());
        Console.WriteLine(r + "amount sold is: " + myRealSalesman.soldAmt);
        Console.WriteLine(r + "commission earned is: " + myRealSalesman.soldAmt);
        Console.WriteLine(r + "commission rate is: " + myRealSalesman.commissionRate);
        Console.ReadLine();
    }
    
}
