namespace A1TopicosIII.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<A1TopicosIII.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "A1TopicosIII.Data.Context";
        }

        protected override void Seed(A1TopicosIII.Data.Context context)
        {
        }
    }
}
