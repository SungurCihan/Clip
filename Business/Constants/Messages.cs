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
        public static string AppointmentUpdated = "Randevu başarıyla güncellendi.";
        public static string AppointmentConflict = "Söz konusu personlein bu saat aralığında zaten bir randevusu var";
        public static string AppointmentTimeRange = "Randevunun bitiş saati başlangıç saatinden erken olamaz.";

        //Customer
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";
        public static string CustomerEmailExistMessage = "Bu e-posta ile kayıtlı bir hesap var.";
        public static string CustomerPhoneNumberExistMessage = "Bu telefon numarası ile kayıtlı bir hesap var.";

        //Comment
        public static string CommentAdded = "Yorum başarıyla eklendi.";
        public static string CommentDeleted = "Yorum başarıyla silindi.";
        public static string CommentUpdated = "Yorum başarıyla güncellendi.";

        //CommentResponse
        public static string CommentResponseAdded = "Yorum yanıtı başarıyla eklendi.";
        public static string CommentResponseDeleted = "Yorum yanıtı başarıyla silindi.";
        public static string CommentResponseUpdated = "Yorum yanıtı başarıyla güncellendi.";

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
        public static string FavoriteLimitExceded = "Bu salonu zaten favorilediniz.";

        //Folower
        public static string FolowerAdded = "Takipçi başarıyla eklendi.";
        public static string FolowerDeleted = "Takipçi başarıyla silindi.";
        public static string FolowerUpdated = "Takipçi başarıyla güncellendi.";
        public static string FolowLimitExceded = "Bu salonu zaten takip ediyorsunuz.";

        //Faq
        public static string FaqAdded = "Sıkça sorulan soru başarıyla eklendi.";
        public static string FaqDeleted = "Sıkça sorulan soru başarıyla silindi.";
        public static string FaqUpdated = "Sıkça sorulan soru başarıyla güncellendi.";

        //Image
        public static string ImageAdded = "Fotoğraf başarıyla eklendi.";
        public static string ImageDeleted = "Fotoğraf başarıyla silindi.";
        public static string ImageUpdated = "Fotoğraf başarıyla güncellendi.";

        //Notification
        public static string NotificationAdded = "Bildirim başarıyla eklendi.";
        public static string NotificationDeleted = "Bildirim başarıyla silindi.";
        public static string NotificationUpdated = "Bildirim başarıyla güncellendi.";

        //SaloonNotification
        public static string SaloonNotificationAdded = "Kuaför bildirimi başarıyla eklendi.";
        public static string SaloonNotificationDeleted = "Kuaför bildirimi başarıyla silindi.";
        public static string SaloonNotificationUpdated = "Kuaför bildirimi başarıyla güncellendi.";
        public static string SaloonNotificationTimeLimitExceded = "Randevu bitiminden sonra 24 saat ile 7 gün aralığında bildirim gönderebilirsiniz.";

        //StarCount
        public static string StarCountAdded = "Yıldız puanı başarıyla eklendi.";
        public static string StarCountDeleted = "Yıldız puanı başarıyla silindi.";
        public static string StarCountUpdated = "Yıldız puanı başarıyla güncellendi.";

        //StarCountType
        public static string StarCountTypeAdded = "Yıldız puanı türü başarıyla eklendi.";
        public static string StarCountTypeDeleted = "Yıldız puanı türü başarıyla silindi.";
        public static string StarCountTypeUpdated = "Yıldız puanı türü başarıyla güncellendi.";

        //SystemNotification
        public static string SystemNotificationAdded = "Sistem bildirimi başarıyla eklendi.";
        public static string SystemNotificationDeleted = "Sistem bildirimi başarıyla silindi.";
        public static string SystemNotificationUpdated = "Sistem bildirimi başarıyla güncellendi.";

        //ProfilePhoto
        public static string ProfilePhotoAdded = "Profil fotoğrafı başarıyla eklendi.";
        public static string ProfilePhotoDeleted = "Profil fotoğrafı başarıyla silindi.";
        public static string ProfilePhotoUpdated = "Profil fotoğrafı başarıyla güncellendi.";

        //SaloonProfilePhoto
        public static string SaloonProfilePhotoAdded = "Kuaför profil fotoğrafı başarıyla eklendi.";
        public static string SaloonProfilePhotoDeleted = "Kuaför profil fotoğrafı başarıyla silindi.";
        public static string SaloonProfilePhotoUpdated = "Kuaför profil fotoğrafı başarıyla güncellendi.";

        //EmployeeProfilPhoto
        public static string EmployeeProfilPhotoAdded = "Personel profil fotoğrafı başarıyla eklendi.";
        public static string EmployeeProfilPhotoDeleted = "Personel profil fotoğrafı başarıyla silindi.";
        public static string EmployeeProfilPhotoUpdated = "Personel profil fotoğrafı başarıyla güncellendi.";

        //Post
        public static string PostAdded = "Gönderi başarıyla eklendi.";
        public static string PostDeleted = "Gönderi başarıyla silindi.";
        public static string PostUpdated = "Gönderi başarıyla güncellendi.";

        //PostComment
        public static string PostCommentAdded = "Gönderi yorumu başarıyla eklendi.";
        public static string PostCommentDeleted = "Gönderi yorumu başarıyla silindi.";
        public static string PostCommentUpdated = "Gönderi yorumu başarıyla güncellendi.";
        public static string PostCommentLimitExceded = "Bir gönderi altına en fazla 5 yorum yapabilirsiniz";

        //PostLike
        public static string PostLikeAdded = "Gönderi beğenisi başarıyla eklendi.";
        public static string PostLikeDeleted = "Gönderi beğenisi başarıyla silindi.";
        public static string PostLikeUpdated = "Gönderi beğenisi başarıyla güncellendi.";
        public static string PostLikeLimitExceded = "Bu gönderiyi zaten beğendiniz.";

        //Saloon
        public static string SaloonAdded = "Kuaför başarıyla eklendi.";
        public static string SaloonDeleted = "Kuaför başarıyla silindi.";
        public static string SaloonUpdated = "Kuaför başarıyla güncellendi.";
        public static string SaloonPhoneNumberRepeats = "Bu telefon numarası ile kayıtlı bir kuaför mevcut.";

        //SaloonComment
        public static string SaloonCommentAdded = "Kuaför yorumu başarıyla eklendi.";
        public static string SaloonCommentDeleted = "Kuaför yorumu başarıyla silindi.";
        public static string SaloonCommentUpdated = "Kuaför yorumu başarıyla güncellendi.";
        public static string SaloonCommentLimitExceded = "Bu randevu için zaten bir yorum yaptınız.";
        public static string SaloonCommentTimeLimitExceded = "Randevu sonrasında 15 dakika ile 24 saat arasında yorum yapabilirsiniz.";

        //SaloonImage
        public static string SaloonImageAdded = "Kuaför resmi başarıyla eklendi.";
        public static string SaloonImageDeleted = "Kuaför resmi başarıyla silindi.";
        public static string SaloonImageUpdated = "Kuaför resmi başarıyla güncellendi.";
        public static string SaloonImageLimitExceded = "Bir kuaför ancak 5 fotoğrafa sahip olabilir.";

        //SaloonStarCount
        public static string SaloonStarCountAdded = "Kuaför yıldız puanı başarıyla eklendi.";
        public static string SaloonStarCountDeleted = "Kuaför yıldız puanı başarıyla silindi.";
        public static string SaloonStarCountUpdated = "Kuaför yıldız puanı başarıyla güncellendi.";

        //Saved
        public static string SavedAdded = "Kaydedilenlere başarıyla eklendi.";
        public static string SavedDeleted = "Kayıtlı gönderi başarıyla silindi.";
        public static string SavedUpdated = "Kaydelienlerden başarıyla güncellendi.";
        public static string SavedLimitExceded = "Bu gönderiyi zaten kaydettiniz.";

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
        public static string PasswordValidation = "Parolanız en az bir küçük harf ve bir sayı içermelidir.";

        //Authorize Messages
        public static string AuthorizedDenied = "Bu işlemi gerçekleişrmeye yetkiniz yok.";

        //UserMessages
        public static string UserRegistered = "Kullanıcı kaydı başarılı.";
        public static string UserNotFound = "Girdiğiniz bilgilere sahip bir kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Bu bilgilere sahip bir kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Access Token oluşturuldu.";
        public static string PhoneNumberRepeats = "Bu telefon numarası ile kayıtlı bir kullanıcı mevcut.";
    }
}
