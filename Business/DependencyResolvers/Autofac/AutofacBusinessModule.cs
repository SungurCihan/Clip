using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
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

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<EmployeeStarCountManager>().As<IEmployeeStarCountService>().SingleInstance();
            builder.RegisterType<EfEmployeeStarCountDal>().As<IEmployeeStarCountDal>().SingleInstance();

            builder.RegisterType<FavoriteManager>().As<IFavoriteService>().SingleInstance();
            builder.RegisterType<EfFavoriteDal>().As<IFavoriteDal>().SingleInstance();

            builder.RegisterType<FolowerManager>().As<IFolowerService>().SingleInstance();
            builder.RegisterType<EfFolowerDal>().As<IFolowerDal>().SingleInstance();

            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<EfImageDal>().As<IImageDal>().SingleInstance();

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

            builder.RegisterType<SaloonStarCountManager>().As<ISaloonStarCountService>().SingleInstance();
            builder.RegisterType<EfSaloonStarCountDal>().As<ISaloonStarCountDal>().SingleInstance();

            builder.RegisterType<SavedManager>().As<ISavedService>().SingleInstance();
            builder.RegisterType<EfSavedDal>().As<ISavedDal>().SingleInstance();


            builder.RegisterType<ServiceManager>().As<IServiceService>().SingleInstance();
            builder.RegisterType<EfServiceDal>().As<IServiceDal>().SingleInstance();

            builder.RegisterType<SocialMediaLinkManager>().As<ISocialMediaLinkService>().SingleInstance();
            builder.RegisterType<EfSocialMediaLinkDal>().As<ISocialMediaLinkDal>().SingleInstance();

            builder.RegisterType<StoryManager>().As<IStoryService>().SingleInstance();
            builder.RegisterType<EfStoryDal>().As<IStoryDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<UserOperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
