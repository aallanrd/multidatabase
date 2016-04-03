namespace WebApp.Controllers
{
    internal class DB
    {
        private int ID;
        private string db_type;
        private string name;

        public DB()
        {

        }
     
         public DB(int id, string db_type, string name)
        {
            this.ID = id;
            this.db_type = db_type;
            this.name = name;

        }
    }
    
}