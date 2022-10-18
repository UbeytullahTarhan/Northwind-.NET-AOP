using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAddedMessage = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";

        public static string ProductCountOfCategoryError = "Bu kategoride max ürün sayısına ulaştınız";

        public static string ProductNameAlreadyExist = "Aynı üründen  birden fazla eklenemez";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
