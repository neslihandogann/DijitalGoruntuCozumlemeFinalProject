import cv2#görüntü şifreleme içim kullanılan open cv kütüphanesidir.
import random

def sifreli_image(kaynak_resim_yolu, key):
    # Görüntüyü yükle
    original_image = cv2.imread(kaynak_resim_yolu)

    # Anahtarı piksel değerlerine dönüştür
    key_pixels = [ord(c) for c in key]

    # Şifreleme işlemini uygula
    sifreli_image = original_image.copy()
    height, width, _ = sifreli_image.shape

    # Rastgele sayı üretmek için seed ayarla seed :rasgele sayı üretecini başlatmak için kullanılan bir sayıdır
    random.seed(key)

    for x in range(width):
        for y in range(height):
            # Piksel değerlerini al
            r, g, b = sifreli_image[y, x]

            # Anahtar ile rastgele sayıyı topla
            rnd = random.randint(0, 255)
            r = (r + key_pixels[0] + rnd) % 256
            g = (g + key_pixels[1] + rnd) % 256
            b = (b + key_pixels[2] + rnd) % 256

            # Şifrelenmiş piksel değerlerini ata
            sifreli_image[y, x] = [r, g, b]

    return sifreli_image

def coz_image(encrypted_image, key):
    # Anahtarı piksel değerlerine dönüştür
    key_pixels = [ord(c) for c in key]

    # Şifre çözme işlemini uygula
    coz_image = encrypted_image.copy()
    height, width, _ = coz_image.shape

    # Rastgele sayı üretmek için seed ayarla
    random.seed(key)

    for x in range(width):
        for y in range(height):
            # Piksel değerlerini al
            r, g, b = coz_image[y, x]

            # Anahtar ile rastgele sayıyı topla
            rnd = random.randint(0, 255)
            r = (r - key_pixels[0] - rnd) % 256
            g = (g - key_pixels[1] - rnd) % 256
            b = (b - key_pixels[2] - rnd) % 256

            # Şifre çözülmüş piksel değerlerini ata
            coz_image[y, x] = [r, g, b]

    return coz_image

kaynak_resim_yolu = "original.jpg"
key = "gizliAnahtar123"

# Görüntüyü şifrele
sifreli_image = sifreli_image(kaynak_resim_yolu, key)

# Şifrelenmiş görüntüyü çöz
coz_image = coz_image(sifreli_image, key)

# Görüntüleri göster
cv2.imshow("Orjinal resim", cv2.imread(kaynak_resim_yolu))
cv2.imshow("sifreli resim", sifreli_image)
cv2.imshow("sifresi cozulmus resim", coz_image)
cv2.waitKey(0)
cv2.destroyAllWindows()



