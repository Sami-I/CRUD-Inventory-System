
# Using .Net 6.0 on https://repl.it

This is a base repl to use when creating a .NET 6 project. Clicking the Run command checks if latest sdk is installed and if not then installs before attempting to run the current project. 

Alternatively you can use the dotnet command as normal to create/run projects from the command prompt.
```
$ ./dotnet -h
```

## Console
To create a sample console project in a folder called Demo
```
$ ./dotnet new console -o Demo
```
To run the project click Run or at prompt
```
$ ./dotnet run -p demo
```

To configure the repl.it Run button, edit the .replit file and change the run command to specify the name of the project to run using -p <projectname> (-p demo in this example)

```
run = "./dotnet run -p demo"

```

## Web
The .NET web tempates try to run the project on ```https``` by default. This doesn't play nice with ```repl.it``` and thus you need to make two small changes to the template.

### Startup.cs
Disable https redirection in the ```Configure(..)``` method
```
 // app.UseHttpsRedirection();
```

### Properties/launchSettings.json
Edit the mvc options object to remove https url from the ```applicationUrl```
```
  "applicationUrl": "http://0.0.0.0:5000",
      
```

Now run the project and it should start normally and be assessible via the public repl url 