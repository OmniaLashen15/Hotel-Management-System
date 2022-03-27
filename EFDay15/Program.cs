using EFDay15.Context;
using EFDay15.Entities;
using Microsoft.EntityFrameworkCore;

using (FrontEnd_ReservationContext Context=new())
{
    Context.Database.Migrate();
    Reservation reservation = new(){
        //ID=1011,
        First_Name="Nazim",
        Last_Name="Amin",
        Birthday="Septemper-0-2012",
        Gender="Male",
        Phone_Number="(999) 999-9999",
        Email_Address= "nazim.amin@gmail.com",
        Number_Guest=2,
        Street_Address= "300 MehWHoCares",
        Apt_Suite="2",
        City= "Brooklyn",
        State= "New York",
        Zip_Code="11218",
        Room_Type= "Single",
        Room_Floor="2",
        Room_Number="205",
        Total_Bill=218.43f,
        Payment_Type="Debit",
        Card_Type= "Discover",
        Card_Number= "6788-6788-6788",
        Card_Exp="03/15",
        Card_CVC="123",
        Arrival_Time= new DateTime(2014,04,27),
        Check_In=true,
        Breakfast=2,
        Lunch=2,
        Dinner=1,
        Cleaning=true,
        Towel=true,
        S_Surprise=true,
        Supply_Status=true,
        Food_Bill=59
    };
    Context.Add(reservation);
    int R= Context.SaveChanges();
    Console.WriteLine($"Number of Rows Affected = {R}");}