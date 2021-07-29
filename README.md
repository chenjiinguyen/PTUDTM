## BOOK COMMUNITY - APP DESKTOP

## INFOMATION

This is a reading community system management application for moderators and administrators. Developed from C# Winform. Use MySQL on the server to connect and use.

## AUTHORS

* chenjiinguyen
* NhuQuynh0711

## OTHER PLATFORMS

* SERVICE - WEBSITE: [https://github.com/chenjiinguyen/book-community-website](https://github.com/chenjiinguyen/book-community-website)
* ANDROID: [https://github.com/chenjiinguyen/book-community-android](https://github.com/chenjiinguyen/book-community-android)

## REQUIREMENT

You need to install and start our system before installing this application.

* SERVICE - WEBSITE: [https://github.com/chenjiinguyen/book-community-website](https://github.com/chenjiinguyen/book-community-website)

## SETUP

After cloning the project, you need Visual Studio to configure the server before you runthe app.

1. Turn on the server.
2. Config file **App.config** in project **GUI** and **DLL** :
```
  <connectionStrings>
    <add name="BOOKCOMMUNITYEntities" connectionString="metadata=res://*/BookCommunity.csdl|res://*/BookCommunity.ssdl|res://*/BookCommunity.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=192.168.1.8;user id=root;password=root;persistsecurityinfo=True;port=33060;database=BOOKCOMMUNITY&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
```

3. Build the app and run it
