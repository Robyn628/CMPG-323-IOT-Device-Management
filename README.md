# CMPG323-Project-3

## 1. Related Repositories for Project 3:
CMPG-323-IOT-Device-Management: https://github.com/Robyn628/CMPG-323-IOT-Device-Management

## 2. Diagram Explaining the Project and Repository Context and how they are Integrated:
![image](https://user-images.githubusercontent.com/88686178/185424250-44988407-8591-4ad6-b46d-7a3beff2780a.png)


## 3. Branching Strategy for Project 3:
![image](https://user-images.githubusercontent.com/88686178/192879053-b6846454-a6fc-4b13-ab67-9ad4768e0564.png) *[1]*


## 4. How the User would use the App:
Once you initiate the app ASP.NET Web Forms then extends the event-driven interaction model to web applications. 
A browser submits a web form to a web server, and the server returns a complete markup page or HTML page as a response.
All client-side user activity is forwarded to the server for stateful processing. 
The server processes the output of client actions and triggers reactions.
The user can input their categories/zones/devices, they can view, edit, and delete them. *[2]*


## 5. How Stakeholders can use the Report that you have Developed:
There are 4 groups of Stakeholders, namely: Providers, Customers, Consumers, and End-Users.


![image](https://user-images.githubusercontent.com/88686178/193003853-d4a29b56-9774-4a35-acc2-44c389011246.png) 
Stakeholder analysis of the ASP model.*[2]*


To evolve the ASP model, ASPs should seek partnerships with other vendors to provide off-the-shelf or off-the-shelf solutions. ASP owns the relationship with the customer. This sets it apart from many outsourcing agreements where customers drive competition between suppliers. Figure 3 shows the major players in the ASP industry. It represents a partnership agreement between service, network and application providers. ASP brings these services together on behalf of the customer. The success of ASP depends on how well these relationships are developed, coordinated, managed, and nurtured.*[3]*


## 4. Use of .gitignore file in each project:
The use of a .gitignore file within this project is to improve data security in that it ensures certain files that arent tracked by Git remain untracked.*[4]*

When committing the project to the GitHub repository, the gitignore file will tell Git which files to ignore.*[5]*


## 5. Storage of Credentials and Sensitive Information:
In an ASP.NET application, you are frequently required to use highly sensitive information. For example, you may need to connect to a database using a user ID and password, or you may be storing user IDs and passwords that customers use to access your application. While secure sockets layer (SSL) can be used to encrypt data as it travels across the network, that data must also be protected when it is stored on both the server and the client. *[6]*

#### When possible, avoid storing sensitive information.
The best way to avoid exposing sensitive information in an application is to not store it in the first place. Reduce the number of locations where sensitive information is stored. Avoid storing sensitive information for your application in a cookie or a persistent control in the browser, which would expose the sensitive information to your application's clients. Keep sensitive information out of your application logic. Retrieve the sensitive information instead from a secure configuration location or from the client. *[6]*

#### Encrypt Private Information
If you store sensitive information, do not store it in human-readable text or in easily decoded formats such as Base64 encoding. Instead, it encrypts the information so that if it is somehow exposed to an attacker, the attacker cannot easily determine the contents of the sensitive information.
Encrypt sensitive information with a one-way hash if you only want to verify the sensitive information and do not need to decrypt it to human readable form. Then, if you want to compare and verify sensitive information received from a source, hash the received value and compare the hashes for verification. For example, if you use ASP.NET Membership and Forms Authentication to provide user authentication for your application, set the password format to Hash so that passwords are not stored in data sources or compared for validation. encrypted with a one-way hash when . 
If you store sensitive information such as connection strings, user credentials, or encryption keys in your application's Web.config file, use a protected configuration provider to encrypt sensitive sections of your Web.config file. For more information about Protected Configuration, see Encrypting Configuration Information Using Protected Configuration. *[6]*

#### Protect Sensitive Information using Permissions
When storing sensitive information in files, databases, the registry, or other locations, use NTFS access control lists and database permissions to restrict access to the information to only necessary sources and necessary access. For more information, see your database documentation or Access Control Lists (ACLs) required by ASP.NET. *[6]*

## 6. References:
[1] - [https://www.dotnetcurry.com/software-gardening/1026/software-branching-practices](https://www.c-sharpcorner.com/article/asp-net-core-2-architecture-design-pattern-ideology/)

[2] - https://www.tutorialspoint.com/asp.net/asp.net_introduction.htm#:~:text=ASP.NET%20web%20forms%20extend,the%20server%20for%20stateful%20processing.

[3] - [https://lbhackney-it.github.io/API-Playbook/branching_strategies/](https://www.researchgate.net/figure/A-stakeholder-analysis-of-the-ASP-model-CONCLUSION-This-paper-has-addressed-some_fig2_221407538)

[4] - https://git-scm.com/docs/gitignore

[5] - https://www.bmc.com/blogs/gitignore/#:~:text=gitignore%20file%20tells%20Git%20which,root%20directory%20of%20your%20repo.&text=%2F%20will%20ignore%20directories%20with%20the,vendor%2F%20ignores%20the%20vendor%20directory.

[6] - https://learn.microsoft.com/en-us/previous-versions/aspnet/kek09k9k(v=vs.100)
