(function(jsGrid) {

    jsGrid.locales.tr = {
        grid: {
            noDataContent: "Kayıt Bulunamadı",
            deleteConfirm: "Emin misiniz ?",
            pAgerFormat: "Sayfalar: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} / {pAgeCount}",
            pAgePrevText: "<",
            pAgeNextText: ">",
            pAgeFirstText: "<<",
            pAgeLastText: ">>",
            loadMessAge: "Lütfen bekleyiniz...",
            invalidMessAge: "Geçersiz veri girişi !"
        },

        loadIndicator: {
            messAge: "Yükleniyor..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Arama moduna geç",
                insertModeButtonTooltip: "Yeni kayıt moduna geç",
                editButtonTooltip: "Değiştir",
                deleteButtonTooltip: "Sil",
                searchButtonTooltip: "Bul",
                clearFilterButtonTooltip: "Filtreyi temizle",
                insertButtonTooltip: "Ekle",
                updateButtonTooltip: "Güncelle",
                cancelEditButtonTooltip: "Güncelleme iptali"
            }
        },

        validators: {
            required: { messAge: "Gerekli alandır" },
            rangeLength: { messAge: "Alan değerinin uzunluğu tanımlanan aralık dışındadır" },
            minLength: { messAge: "Alan değeri çok kısadır" },
            maxLength: { messAge: "Alan değeri çok uzundur" },
            pattern: { messAge: "Alan değeri tanımlanan şablon ile eşleşmiyor" },
            range: { messAge: "Alan değeri tanımlı aralığın dışındadır" },
            min: { messAge: "Alan değeri çok küçüktür" },
            max: { messAge: "Alan değeri çok büyüktür" }
        }
    };

}(jsGrid, jQuery));

