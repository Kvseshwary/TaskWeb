# TaskWeb
### Any assumptions you made

Visual Studio 2017 to create ASP.NET Web API  that returns a list of Person. The front-end web page uses Html page with jQuery to display the results.

1)There are 2 class present in Controllers ValuesController.cs 
   MyWebApp.Controllers

    1)Person
    2)Product

2)Person Class has the following public properties

    1)MemberNumber
    2)ForeName
    3)Surname 

3)Person Class has a collection of products that person holds which has the product name,cost associated with  the person

4)Data in the  Person & Product classes are hardcoded within the  ValuesController.cs file.

### How to build your application


1)Open the project in visual studio 2017

2)Set index.html as the start page

3)Build the solution by clicking Build | Build Solution.

### How to test your application

1)Press F5 to run the project. The browser will load the HTML document.

2)Once the Web API call completes you should see the person details returned from the Web API call displayed as list items in the browser.

3)You can  Request in the localhost by using the following command which display the 
Xml result of the data
http://localhost:/api/Person

4)Client-Side AJAX ,The response is  displayed in the index.html page

#### How to run your application

1)Press F5 to run the project. The browser will load the HTML document.

2)Once the Web API call completes you should see the person details returned from the Web API call displayed as list items in the browser.

3)You can see the Request Call in the localhost by using the following command which display the 
Xml result of the data
http://localhost:/api/Person

4)The response is via AJAX call displayed in the index.html page




