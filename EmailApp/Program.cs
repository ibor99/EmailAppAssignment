// See https://aka.ms/new-console-template for more information
using EmailApp;
using System;
using System.Net;
using System.Net.Mail;

Console.WriteLine("Enter your email address:");
string recipientEmail = Console.ReadLine();

EmailSender sender = new EmailSender();

sender.SendEmail(recipientEmail);

Console.WriteLine("Email attempted to send. Press any key to exit.");
Console.ReadKey();

