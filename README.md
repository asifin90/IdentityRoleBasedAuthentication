# IdentityRoleBasedAuthentication
Role based authentication in asp.net core 3.1

This application created for understanding Asp.net Core role based authentication.

Follow below step to make it work:
1. Please remove migration folder from solution.
2. Go to AppSettings.Json file and provide connection string for you system or where SQL server installed.
3. Open Package Manager Console Window and run below Commands
  a. Add-Migration IdentityRoleBased
  b. Update-Database
4. Once above commands run successfully and Migration Folder created, run application and create few users from Register View

