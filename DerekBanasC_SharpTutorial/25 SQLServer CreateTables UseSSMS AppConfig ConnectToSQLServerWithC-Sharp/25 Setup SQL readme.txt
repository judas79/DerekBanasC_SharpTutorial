This C# Tutorial is going to cover a lot in a short video. I’ll set up the newest SQL Server and Visual Studio 2017. 
I’ll then explore Creating Tables, Using SSMS, App.config, Connecting to SQL Server with C# and a whole lot more.

First we will download the Windows C# developer edition of the SQL server, and possibly sign up for a SQL account here:
https://www.microsoft.com/en-us/sql-server/developer-get-started/csharp/win

Choose the highlighted 'here', in this line: 
If you don’t have SQL Server 2017 Developer (or above) installed, click here to download the SQL Server exe.
and click on the download when finished.

Run it to start the SQL installer.
Click Basic in Select an installation type.
Click Accept after you have read the license terms.
(Optional) if you need to, you can choose a custom installation location for SQL Server.
Click Install to proceed with the installation.
You now have SQL Server installed and running locally on your Windows computer! 
Save the installation notes for use later:

INSTANCE NAME            CONNECTION STRING
MSSQLSERVER              Server=localhost;Database=master;Trusted_Connection=True;

SQL Administrators		 SQL SERVER INSTALL LOG FOLDER
DESKTOP-ORADNIK\judas    C:\Program Files\Microsoft SQL Server\140\Setup Bootstrap\Log\20210130_214753

FEATRURES INSTALLED		 INSTALLATION MEDIA FOLDER
SQLENGINE				 C:\SQLServer2017Media\Developer_ENU

VERSION					 INSTALLATION RESOURCES FOLDER
14.0.1000.169, RTM		 C:\Program Files\Microsoft SQL Server\140\SSEI\Resources

Do not close this window yet!
Check out the next section to continue installing prerequisites.


Next click on 'Install SSMS' at the bottom, of your "Installation has completed successfully" window.
You will be directed to a new web page, that will pop-up.

On this web page, download SSMS, from this Link:
Download SQL Server Management Studio (SSMS)
https://aka.ms/ssmsfullsetup
When that finishes downloading, it should pop-up opened, or click on it, to open, if it doesn't.
Install - Microsoft SQL Server Management Studio 18.
When the app pop-up show app installed successfully, close it, or restart, if that is the option.


Next, go into your windows Start and click on "Microsoft SQL Server Management", to start it up.
Hopefully you saved the installation notes, earlier, because you will need to know the
'SQL ADMINISTRATORS' Name, that looks like something like this:
'DESKTOP-ORADNIK\judasbut with your name, instead of judas, as shown here.

In the  ''connect to server' press 'Connect', at the bottom of the box.  If you are missing the 'Server Name' feild,
In the field box, click 'browse for more'.  In the box that pops up, under the 'Local Servers' tab, expand the
'DataBase Engine' and selected one of the servers, in there.  Now 'Connect' to the server.

At this point go to visual studio website and install the free Visual Studio Comunity edition, if it isn't already installed.
Launch Visual Studio.  
NOT IN THE TUTORIAL
"CREATE A NEW C# CONSOLE PROJECT SO YOU WILL HAVE A Program.cs file in it, when we get to that point"
Under the View tab, click 'Server Explorer'.
In ther server explorer box that pops up, right click on 'Data Connections' and choose 'Create New SQL Server Database...'
If you are prompted to install missing packages, go ahead and install them.
If no updates are needed, continue by creating a 'New database name'.  The name I used was
'StoreDB'.  I your server name field is empty, enter the same server name you ued earlier.  Leave
the Use windows Authentiction, selected, and press 'OK".
Database is now setup!

Next we will set up the Table.  In your Server Explore box, expand the triangle next to your servers name, 
then right click on Tables and select 'Add New Table'.  Next set up your empty database, exactly like the
databaseExample.png in the same folder, as this tutorial.
Also, at the bottom of your dbo database page change 'Tables' to Products, and add 'IDENTITY, 
to the '[ProdID]' line.
Next, go back up to the top of your database page and click 'Update'.  Then in the popup window click,
'Update Database'.

Next we will go back into the Server Explorer box, and put some actual data, into our databse.
Expand the Tables folder, then Right click on 'Products' and choose 'Show Table Data'. In the table that popsup,
enter the Products.png example content.

After completeing that table, right click on Products and choose 'Add New Table' and copy the example text in the
Customers.png table contents.  The name of the table also being 'Customers', which you can change at the bottom of this
database page, by changing [Table] to [Customers].


Next we will write some code to connect to the database. First, in solution Explorer,right click the 'Reference' tab,
click on 'add reference'.  In the window that pops up, put a check next to 'System Configuration';  press OK

Next, double click your App.Config file, in Solution Explorer, to open it up.  The app config, is for storing
configuration data, that we use to connect to the database.  We will add appsettings configuration to connect to 
the SOL server, in the <configuration> section, before the <startup> section; see '25 App.config.txt'.
  The library used is:  System.Data.SqlClient
  Highlight your server in server explorer, then in your propertiex box,
  in VS on the bottom right, copy the in your 'Connection String' box, and paste it in for the 'value'
See the App.Config.png.

Next, open your Program.cs file. 

Then we have to add two libraries to the Prgram.cs:

using System.Data.Common;
using System.Configuration;

See the '25 Program.cs.txt' file to finish all the prerequesits to complete you SQL server connection,
and test it.  The explanations, of the code, are in the comments within the code, in that document.
