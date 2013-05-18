Desktop Utilities 1.2
(C) 2012 Christopher Walker

About this program...

I made this C# program to provide a quick utility that would help me when I’m developing.  It provides panels to start/stop services, a colour picker that outputs the colour information in various useful formats, a desktop timer, a gamma adjuster and a Lorem Ipsum text generator.

The services tab reads a file in the installation directory called 'services.dat'. By default, this file should be in folder:

C:\Program Files\Christopher Walker\Desktop Utilities 1.2\

It's a simple ASCII text file, and in here you add the services you want to have in your list. To customise the list, you need to go into:

Start -> Settings -> Control Panel -> Administrative Tools -> Services

If you double click on the services you wish to add to the application, you will see that at the top, highlighted by default, is the service name.  Copy and paste these into the 'services.dat' file, and in front of each, put a descriptive title for the service followed by a colon.
e.g. for the SQL Server Express service, called MSSQL$SQLEXPRESS, the line would read:

SQL Server Express:MSSQL$SQLEXPRESS

Do this for every service you want to control, with each service on a separate line, and that's it!
Run the Desktop Utilities program and you will see a list of your chosen services, with start and stop buttons beside them. You can drop a shortcut to the program in your quick launch for easy access.

The colour picker is fairly obvious to use. Just click on the coloured square, select your colour, and hit OK. The screen will reflect the colour in various RGB formats and in HSL. Simply copy and paste what you want to where you want to use it.

Gamma settings are saved when you exit the utility, and restored when you run it again. Simply drag the slider and that’s it! You can run DesktopUtilities.exe with the command line argument ‘-gamma’ to silently start the program up, apply the last gamma setting and just exit. Handy for adding to your startup folder to quietly apply your favourite gamma setting as soon as you log in.

The timer tab is a simply start/stop/pause timer that I find useful when I need to accurately invoice clients for time spent on development work. You can flick to other tabs without disrupting the timer. Note that you must keep the Desktop Utilities program open and running, so just minimise the window as you work to keep track of the time you’re spending.

TheLorem Ipsum generator allows you to create 100 paragraphs or 9000 words of Lorem Ipsum test text. Just select ‘Paragraphs’ or ‘Words’ from the drop-down list, and select how many you want with the slider. It automatically generates the text and copies it to the clipboard once it’s done. You can also subsequently click on the generated text to copy the text to the clipboard again.

This program is provided as-is, and whilst I have taken every precaution to ensure the program is safe to use, I cannot be held liable or responsible for any damage it may cause. You use this software entirely at your own risk.

Enjoy, and feel free to issue copies to your friends if they want it. The program has been issued under GPL GNU version 3 license, a copy of which is enclosed, so please ensure that if you supply a copy to someone, you send them the original archive that includes all the files and a copy of the license. Many thanks.

C Walker.
