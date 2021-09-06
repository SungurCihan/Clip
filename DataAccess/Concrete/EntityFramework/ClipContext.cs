using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ClipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Clip;Trusted_Connection=true");
        }

        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SaloonImage> SaloonImages { get; set; }
        public DbSet<SocialMediaLink> SocialMediaLinks { get; set; }
        public DbSet<SaloonComment> SaloonComments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Folower> Folowers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentResponse> CommentResponses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Saved> Saveds { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SaloonNotification> SaloonNotifications { get; set; }
        public DbSet<SystemNotification> SystemNotifications { get; set; }
        public DbSet<StarCount> StarCounts { get; set; }
        public DbSet<StarCountType> StarCountTypes { get; set; }
        public DbSet<ProfilePhoto> ProfilePhotos { get; set; }
        public DbSet<SaloonProfilePhoto> SaloonProfilePhotos { get; set; }
        public DbSet<EmployeeProfilePhoto> EmployeeProfilePhotos { get; set; }

    }
}

