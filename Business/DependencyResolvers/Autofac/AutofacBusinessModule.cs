using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppointmentManager>().As<IAppointmentService>().SingleInstance();
            builder.RegisterType<EfAppointmentDal>().As<IAppointmentDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();

            builder.RegisterType<CommentResponseManager>().As<ICommentResponseService>().SingleInstance();
            builder.RegisterType<EfCommentResponseDal>().As<ICommentResponseDal>().SingleInstance();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<EmployeeProfilePhotoManager>().As<IEmployeeProfilePhotoService>().SingleInstance();
            builder.RegisterType<EfEmployeeProfilePhotoDal>().As<IEmployeeProfilePhotoDal>().SingleInstance();

            builder.RegisterType<FavoriteManager>().As<IFavoriteService>().SingleInstance();
            builder.RegisterType<EfFavoriteDal>().As<IFavoriteDal>().SingleInstance();

            builder.RegisterType<FaqManager>().As<IFaqService>().SingleInstance();
            builder.RegisterType<EfFaqDal>().As<IFaqDal>().SingleInstance();

            builder.RegisterType<FolowerManager>().As<IFolowerService>().SingleInstance();
            builder.RegisterType<EfFolowerDal>().As<IFolowerDal>().SingleInstance();

            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<EfImageDal>().As<IImageDal>().SingleInstance();

            builder.RegisterType<NotificationManager>().As<INotificationService>().SingleInstance();
            builder.RegisterType<EfNotificationDal>().As<INotificationDal>().SingleInstance();

            builder.RegisterType<SaloonNotificationManager>().As<ISaloonNotificationService>().SingleInstance();
            builder.RegisterType<EfSaloonNotificationDal>().As<ISaloonNotificationDal>().SingleInstance();

            builder.RegisterType<SystemNotificationManager>().As<ISystemNotificationService>().SingleInstance();
            builder.RegisterType<EfSystemNotificationDal>().As<ISystemNotificationDal>().SingleInstance();

            builder.RegisterType<PostCommentManager>().As<IPostCommentService>().SingleInstance();
            builder.RegisterType<EfPostCommentDal>().As<IPostCommentDal>().SingleInstance();

            builder.RegisterType<PostLikeManager>().As<IPostLikeService>().SingleInstance();
            builder.RegisterType<EfPostLikeDal>().As<IPostLikeDal>().SingleInstance();

            builder.RegisterType<PostManager>().As<IPostService>().SingleInstance();
            builder.RegisterType<EfPostDal>().As<IPostDal>().SingleInstance();

            builder.RegisterType<SaloonCommentManager>().As<ISaloonCommentService>().SingleInstance();
            builder.RegisterType<EfSaloonCommentDal>().As<ISaloonCommentDal>().SingleInstance();

            builder.RegisterType<SaloonManager>().As<ISaloonService>().SingleInstance();
            builder.RegisterType<EfSaloonDal>().As<ISaloonDal>().SingleInstance();

            builder.RegisterType<SaloonImageManager>().As<ISaloonImageService>().SingleInstance();
            builder.RegisterType<EfSaloonImageDal>().As<ISaloonImageDal>().SingleInstance();

            builder.RegisterType<SaloonProfilePhotoManager>().As<ISaloonProfilePhotoService>().SingleInstance();
            builder.RegisterType<EfSaloonProfilePhotoDal>().As<ISaloonProfilePhotoDal>().SingleInstance();

            builder.RegisterType<SavedManager>().As<ISavedService>().SingleInstance();
            builder.RegisterType<EfSavedDal>().As<ISavedDal>().SingleInstance();

            builder.RegisterType<ServiceManager>().As<IServiceService>().SingleInstance();
            builder.RegisterType<EfServiceDal>().As<IServiceDal>().SingleInstance();

            builder.RegisterType<SocialMediaLinkManager>().As<ISocialMediaLinkService>().SingleInstance();
            builder.RegisterType<EfSocialMediaLinkDal>().As<ISocialMediaLinkDal>().SingleInstance();

            builder.RegisterType<StarCountManager>().As<IStarCountService>().SingleInstance();
            builder.RegisterType<EfStarCountDal>().As<IStarCountDal>().SingleInstance();

            builder.RegisterType<StarCountTypeManager>().As<IStarCountTypeService>().SingleInstance();
            builder.RegisterType<EfStarCountTypeDal>().As<IStarCountTypeDal>().SingleInstance();

            builder.RegisterType<StoryManager>().As<IStoryService>().SingleInstance();
            builder.RegisterType<EfStoryDal>().As<IStoryDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<ProfilePhotoManager>().As<IProfilePhotoService>().SingleInstance();
            builder.RegisterType<EfProfilePhotoDal>().As<IProfilePhotoDal>().SingleInstance();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
