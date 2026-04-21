# 📖 Entity Rehberi — Türkçe Karşılıklar

---

## 🔷 BaseEntity *(Tüm entity'lerin atası)*
| Property | Tür | Türkçe |
|---|---|---|
| `Id` | Guid | Benzersiz kimlik |
| `CreatedAt` | DateTime | Oluşturulma tarihi |
| `UpdatedAt` | DateTime? | Güncellenme tarihi |
| `IsDeleted` | bool | Silindi mi? (soft delete) |

---

## 👤 User *(Kullanıcı)*
| Property | Tür | Türkçe |
|---|---|---|
| `FirstName` | string | Ad |
| `LastName` | string | Soyad |
| `Email` | string | E-posta |
| `PhoneNumber` | string | Telefon numarası |
| `PasswordHash` | string | Şifre (şifrelenmiş) |
| `Role` | UserRole | Rol (Admin/Müşteri) |

---

## 🏠 Address *(Adres)*
| Property | Tür | Türkçe |
|---|---|---|
| `UserId` | Guid | Kullanıcı FK |
| `RecipientName` | string | Alıcı adı soyadı |
| `City` | string | İl |
| `District` | string | İlçe |
| `Neighborhood` | string | Mahalle |
| `AddressDetail` | string | Adres detayı |
| `AddressTitle` | string | Adres başlığı (Ev, İş…) |
| `PhoneNumber` | string | Telefon |

---

## 🏷️ Brand *(Marka)*
| Property | Tür | Türkçe |
|---|---|---|
| `Name` | string | Marka adı |
| `LogoUrl` | string? | Logo resim linki |

---

## 📂 Category *(Kategori)*
| Property | Tür | Türkçe |
|---|---|---|
| `Name` | string | Kategori adı |
| `Gender` | CategoryGender? | Cinsiyet (Kadın/Erkek/Çocuk) |
| `ParentCategoryId` | Guid? | Üst kategori FK |
| `IconUrl` | string? | İkon resim linki |
| `SortOrder` | int | Sıralama |
| `IsActive` | bool | Aktif mi? |

---

## 👕 Product *(Ürün)*
| Property | Tür | Türkçe |
|---|---|---|
| `Name` | string | Ürün adı |
| `CategoryId` | Guid | Kategori FK |
| `BrandId` | Guid | Marka FK |
| `Description` | string? | Ürün açıklaması |
| `Seller` | string? | Satıcı |
| `ListPrice` | decimal | Liste fiyatı |
| `SalePrice` | decimal | Satış fiyatı |
| `IsActive` | bool | Aktif mi? |

---

## 🎨 ProductVariant *(Ürün Varyantı)*
| Property | Tür | Türkçe |
|---|---|---|
| `ProductId` | Guid | Ürün FK |
| `ColorId` | Guid | Renk FK → Color tablosuna bağlı |
| `SizeId` | Guid | Beden FK → Size tablosuna bağlı |
| `SKU` | string | Benzersiz ürün kodu (örn: LCW-001-MAVI-M) |
| `Price` | decimal? | Varyanta özel fiyat (null ise Product.SalePrice geçerli) |
| `Length` | string? | Uzunluk (Kısa/Normal/Uzun) |
| `Stock` | int | Stok adedi |

---

## 🔴 Color *(Renk)*
| Property | Tür | Türkçe |
|---|---|---|
| `Name` | string | Renk adı (Kırmızı, Mavi...) |
| `HexCode` | string | Renk kodu (#FF0000) — renk kutucuğu göstermek için |

---

## 📐 Size *(Beden)*
| Property | Tür | Türkçe |
|---|---|---|
| `Name` | string | Beden adı (XS, S, M, L, XL) |
| `SortOrder` | int | Sıralama (XS=1, S=2, M=3...) — küçükten büyüğe sıralar |

---

## 🖼️ ProductImage *(Ürün Görseli)*
| Property | Tür | Türkçe |
|---|---|---|
| `ProductId` | Guid | Ürün FK |
| `ImageUrl` | string | Resim linki |
| `SortOrder` | int | Gösterim sırası |
| `IsCover` | bool | Kapak resim mi? |

---

## 🛒 Cart *(Sepet)*
| Property | Tür | Türkçe |
|---|---|---|
| `UserId` | Guid | Kullanıcı FK |

---

## 🛒 CartItem *(Sepet Kalemi)*
| Property | Tür | Türkçe |
|---|---|---|
| `CartId` | Guid | Sepet FK |
| `ProductVariantId` | Guid | Ürün varyantı FK |
| `Quantity` | int | Adet |

---

## 📦 Order *(Sipariş)*
| Property | Tür | Türkçe |
|---|---|---|
| `UserId` | Guid | Kullanıcı FK |
| `OrderNumber` | string | Sipariş numarası |
| `SubTotal` | decimal | Ara toplam |
| `GrandTotal` | decimal | Genel toplam |
| `Status` | OrderStatus | Sipariş durumu |
| `OrderDate` | DateTime | Sipariş tarihi |
| `OrderSummary` | string? | Sipariş notu |
| `ShippingAddressId` | Guid | Teslimat adresi FK |
| `BillingAddressId` | Guid | Fatura adresi FK |
| `ShippingFee` | decimal | Kargo ücreti |
| `CashOnDeliveryFee` | decimal | Kapıda ödeme ücreti |
| `DiscountAmount` | decimal | İndirim tutarı |
| `CouponCode` | string? | Kullanılan kupon kodu |
| `CouponDiscount` | decimal | Kupon indirim tutarı |

---

## 📋 OrderItem
| Property | Tür | Türkçe |
|---|---|---|
| `OrderId` | Guid | Sipariş FK |
| `ProductVariantId` | Guid | Ürün varyantı FK |
| `Quantity` | int | Adet |
| `UnitPrice` | decimal | Birim fiyat (sipariş anındaki) |
| `ProductName` | string | Ürün adı snapshot — ürün silinse bile korunur |
| `ColorName` | string? | Renk adı snapshot |
| `SizeName` | string? | Beden adı snapshot |
| `ImageUrl` | string? | Ürün görseli snapshot |

---

## 💳 Payment *(Ödeme)*
| Property | Tür | Türkçe |
|---|---|---|
| `OrderId` | Guid | Sipariş FK |
| `BillingAddressId` | Guid? | Fatura adresi FK |
| `Method` | PaymentMethod | Ödeme yöntemi |
| `Status` | PaymentStatus | Ödeme durumu |
| `BankName` | string? | Banka adı |
| `InstallmentCount` | int | Taksit sayısı |
| `InvoiceNumber` | string? | Fatura numarası |
| `IsBillingSameAsShipping` | bool | Fatura = teslimat adresi mi? |
| `CreditInstallmentCount` | int? | Alışveriş kredisi vade sayısı |
| `CreditInstallmentDifference` | decimal? | Kredi vade farkı |
| `DeliveryType` | DeliveryType | Teslimat türü |
| `EstimatedDeliveryDate` | DateTime? | Tahmini teslimat tarihi |

---

## 🔄 ReturnOrder *(İade)*
| Property | Tür | Türkçe |
|---|---|---|
| `OrderId` | Guid | Sipariş FK |
| `ReturnCode` | string | İade kodu |
| `ReturnReason` | string | İade sebebi |
| `Status` | ReturnStatus | İade durumu |
| `CargoCompany` | string? | Kargo firması |
| `TrackingNumber` | string? | Kargo takip numarası |
| `RefundAmount` | decimal | İade tutarı |
| `ReturnDate` | DateTime? | İade tarihi |
| `RejectionReason` | string? | Red sebebi |
| `RefundMethod` | ReturnMethod? | İade yöntemi |

---

## 🔢 Enum Rehberi

| Enum | Değerler | Türkçe |
|---|---|---|
| `OrderStatus` | Received, Preparing, Shipped, Delivered, Cancelled | Alındı, Hazırlanıyor, Kargoda, Teslim Edildi, İptal |
| `PaymentStatus` | Pending, Successful, Failed, Refunded | Beklemede, Başarılı, Başarısız, İade Edildi |
| `PaymentMethod` | CreditOrDebitCard, CashOnDelivery | Kredi/Banka Kartı, Kapıda Ödeme |
| `ReturnStatus` | Requested, Approved, Rejected, Completed | Talep Edildi, Onaylandı, Reddedildi, Tamamlandı |
| `ReturnMethod` | Wallet, SameCard, BankTransfer | Cüzdan, Aynı Kart, Havale |
| `CategoryGender` | Women, Men, Kids, Unisex | Kadın, Erkek, Çocuk, Unisex |
| `DeliveryType` | HomeDelivery, StorePickup | Adrese Teslimat, Mağazadan Al |
| `UserRole` | SuperAdmin, ProductAdmin, Customer | Süper Admin, Ürün Admini, Müşteri |

---

## 🗺️ İlişki Haritası

```
User
 ├── Address[]          (1 kullanıcı → N adres)
 ├── Cart               (1 kullanıcı → 1 sepet)
 └── Order[]            (1 kullanıcı → N sipariş)

Cart
 └── CartItem[]         (1 sepet → N kalem)
      └── ProductVariant

Product
 ├── ProductVariant[]   (1 ürün → N varyant: beden+renk)
 └── ProductImage[]     (1 ürün → N görsel)

Category
 └── SubCategories[]    (self-referencing: Kadın → Elbise → Midi Elbise)

Order
 ├── OrderItem[]        (1 sipariş → N kalem)
 ├── Payment            (1 sipariş → 1 ödeme)
 └── ReturnOrder[]      (1 sipariş → N iade talebi)
```
