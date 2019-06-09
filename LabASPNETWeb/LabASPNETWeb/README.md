# LabASPNETWeb

## Sitemap


  - **Home/Index**: Hello, display news in website.
  - **Home/Login**: Form login.
  - **Home/UserInfor**: Display user information.
  - **Admin/ListNews**: List news.
  - **Admin/NewsManagement**: CRUD news.


## Database model
  1. **Prefix DB**: wp
  2. **Type_db**: SQLLocalDB
     1. *Syntax*: CMD > SQLLocalDB start
     2. *Default Instance name*: MSSQLLocalDB
     3. *Database name*: LabWebAppAspNet
     3. *Connect name*: (localdb)\\(intancename)
  3. **Tables**
     1. wpUsers
        1. username
        2. email
        3. name
        4. createdt
        5. lastupdt
        6. activeyn
        7. lastlogindt
        8. pwd
     2. wpNews
        1. id
        2. title
        3. content
        4. tags
        5. usr_create
        6. createdt
        7. lastupdt
        8. activeyn
        9. homepageyn
