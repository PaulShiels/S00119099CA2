
Music Store App
=============================================

Home page displays a list of Orders for Albums

I added the Authorize Attribute method to the filterConfig.cs file to secure the ActionResult methods. 
I added [AllowAnonymous] to any ActionResult methods that did not need secured.
ValidateAntiForgeryToken to prevent against XSS

Added new table called users with 3 colums - email,password, passwordSalt

links at top work
Search for works
sort by works
albums button works
back button works in album view


Register
   Takes email address and password
-----------
------
---------

Log In
   Takes email and password and check if they are avainlable in the DB and logs the user in.


All edit, details and delete buttons work
   They check if a user is logged in and if not they are redirected to the Login page.
   If a user is logged in the the page is redirected to the appropiate page, in this case a
   page with the message "This page is under development"
   Also the user will be redirected to the homepage in 5 seconds.

Tryed to encode URL