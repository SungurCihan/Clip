using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Appointment
        public static string AppointmentAdded = "Randevu başarıyla eklendi.";
        public static string AppointmentDeleted = "Randevu başarıyla silindi.";
        public static string AppointmentUpdated = "Randevu başarıyla güncellendi.  asdasdas";     

        //Customer
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";
        public static string CustomerEmailExistMessage = "Bu e-posta ile kayıtlı bir hesap var.";
        public static string CustomerPhoneNumberExistMessage = "Bu telefon numarası ile kayıtlı bir hesap var.";

        //Employee
        public static string EmployeeAdded = "Personel başarıyla eklendi.";
        public static string EmployeeDeleted = "Personel başarıyla silindi.";
        public static string EmployeeUpdated = "Personel başarıyla güncellendi.";

        //EmployeeStarCount
        public static string EmployeeStarCountAdded = "Personel yıldız puanı başarıyla eklendi.";
        public static string EmployeeStarCountDeleted = "Personel yıldız puanı başarıyla silindi.";
        public static string EmployeeStarCountUpdated = "Personel yıldız puanı başarıyla güncellendi.";

        //Favorite
        public static string FavoriteAdded = "Favori başarıyla eklendi.";
        public static string FavoriteDeleted = "Favori başarıyla silindi.";
        public static string FavoriteUpdated = "Favori başarıyla güncellendi.";

        //Folower
        public static string FolowerAdded = "Takipçi başarıyla eklendi.";
        public static string FolowerDeleted = "Takipçi başarıyla silindi.";
        public static string FolowerUpdated = "Takipçi başarıyla güncellendi.";

        //Image
        public static string ImageAdded = "Fotoğraf başarıyla eklendi.";
        public static string ImageDeleted = "Fotoğraf başarıyla silindi.";
        public static string ImageUpdated = "Fotoğraf başarıyla güncellendi.";

        //Post
        public static string PostAdded = "Gönderi başarıyla eklendi.";
        public static string PostDeleted = "Gönderi başarıyla silindi.";
        public static string PostUpdated = "Gönderi başarıyla güncellendi.";

        //PostComment
        public static string PostCommentAdded = "Gönderi yorumu başarıyla eklendi.";
        public static string PostCommentDeleted = "Gönderi yorumu başarıyla silindi.";
        public static string PostCommentUpdated = "Gönderi yorumu başarıyla güncellendi.";

        //PostLike
        public static string PostLikeAdded = "Gönderi beğenisi başarıyla eklendi.";
        public static string PostLikeDeleted = "Gönderi beğenisi başarıyla silindi.";
        public static string PostLikeUpdated = "Gönderi beğenisi başarıyla güncellendi.";

        //Saloon
        public static string SaloonAdded = "Kuaför başarıyla eklendi.";
        public static string SaloonDeleted = "Kuaför başarıyla silindi.";
        public static string SaloonUpdated = "Kuaför başarıyla güncellendi.";

        //SaloonComment
        public static string SaloonCommentAdded = "Kuaför yorumu başarıyla eklendi.";
        public static string SaloonCommentDeleted = "Kuaför yorumu başarıyla silindi.";
        public static string SaloonCommentUpdated = "Kuaför yorumu başarıyla güncellendi.";

        //SaloonImage
        public static string SaloonImageAdded = "Kuaför resmi başarıyla eklendi.";
        public static string SaloonImageDeleted = "Kuaför resmi başarıyla silindi.";
        public static string SaloonImageUpdated = "Kuaför resmi başarıyla güncellendi.";

        //SaloonStarCount
        public static string SaloonStarCountAdded = "Kuaför yıldız puanı başarıyla eklendi.";
        public static string SaloonStarCountDeleted = "Kuaför yıldız puanı başarıyla silindi.";
        public static string SaloonStarCountUpdated = "Kuaför yıldız puanı başarıyla güncellendi.";

        //Saved
        public static string SavedAdded = "Kaydedilenlere başarıyla eklendi.";
        public static string SavedDeleted = "Kayıtlı gönderi başarıyla silindi.";
        public static string SavedUpdated = "Kaydelienlerden başarıyla güncellendi.";

        //Service
        public static string ServiceAdded = "Hizmet başarıyla eklendi.";
        public static string ServiceDeleted = "Hizmet başarıyla silindi.";
        public static string ServiceUpdated = "Hizmet başarıyla güncellendi.";

        //SocialMediaLink
        public static string SocialMediaLinkAdded = "Sosyal medya linki başarıyla eklendi.";
        public static string SocialMediaLinkDeleted = "Sosyal medya linki başarıyla silindi.";
        public static string SocialMediaLinkUpdated = "Sosyal medya linki başarıyla güncellendi.";

        //Story
        public static string StoryAdded = "Hikaye başarıyla eklendi.";
        public static string StoryDeleted = "Hikaye başarıyla silindi.";
        public static string StoryUpdated = "Hikaye başarıyla güncellendi.";

        //User
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";

        //Story
        public static string OperationClaimAdded = "OperationClaim başarıyla eklendi.";
        public static string OperationClaimDeleted = "OperationClaim başarıyla silindi.";
        public static string OperationClaimUpdated = "OperationClaim başarıyla güncellendi.";

        //UserOperationClaim
        public static string UserOperationClaimAdded = "UserOperationClaim başarıyla eklendi.";
        public static string UserOperationClaimDeleted = "UserOperationClaim başarıyla silindi.";
        public static string UserOperationClaimUpdated = "UserOperationClaim başarıyla güncellendi.";

        //Validation Messages
        public static string PasswordValidation = "Parolanız büyük harf, küçük harf ve sayı içermelidir.";

        //Authorize Messages
        public static string AuthorizedDenied = "Bu işlemi gerçekleişrmeye yetkiniz yok.";

        //UserMessages
        public static string UserRegistered = "Kullanıcı kaydı başarılı.";
        public static string UserNotFound = "Girdiğiniz bilgilere sahip bir kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Bu bilgilere sahip bir kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Access Token oluşturuldu.";
    }
}
