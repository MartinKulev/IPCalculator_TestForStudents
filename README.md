# About app
When a student starts up the app, a random IP address and a random subnet count is chosen. The student has to answer questions about the given IP address. When he turns in the test, he can see his right and wrong answers. The coding logic of the [IP-Calculator](https://github.com/MartinKulev/IP-Calculator) is reused for calculating the right answers. After a test is turned in, it's stored in a database. The [IP-Calculator-AnswerCheckerForTeachers](https://github.com/MartinKulev/IP-Calculator-AnswerCheckerForTeachers) extracts all tests from the database and presents them to the teacher. This project was part of my thesis project for graduating high school, and it is now used in the educational process at my school.

# Hosting
The app is hosted here: [https://iptestform.azurewebsites.net](https://iptestform.azurewebsites.net)
> [!NOTE]
> If you want to run the app locally, you would have to add a connection string and do a migration.
