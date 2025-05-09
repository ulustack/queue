using System;
using System.Collections.Generic;

public class KullaniciYonetimi
{
    private HashSet<string> kullaniciKimlikleri;

    public KullaniciYonetimi()
    {
        kullaniciKimlikleri = new HashSet<string>();
    }

    public bool KullaniciEkle(string postId)
    {
        // Eğer kullanıcı zaten varsa false döner, yoksa ekler ve true döner
        return kullaniciKimlikleri.Add(postId);
    }

    public bool VarMi(string postId )
    {
        return kullaniciKimlikleri.Contains(postId);
    }

    public void TumKullanicilariListele()
    {
        foreach (var kullanici in kullaniciKimlikleri)
        {
            Console.WriteLine($"🔹 {kullanici}");
        }
    }

    public int ToplamKullaniciSayisi()
    {
        return kullaniciKimlikleri.Count;
    }
}
