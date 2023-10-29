(function(jsGrid) {

    jsGrid.locales.ka = {
        grid: {
            noDataContent: "მონაცემები ცარიელია.",
            deleteConfirm: "ნამდვილად გსურთ ჩანაწერის წაშლა?",
            pAgerFormat: "გვერდები: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} - {pAgeCount} დან.",
            pAgePrevText: "<",
            pAgeNextText: ">",
            pAgeFirstText: "<<",
            pAgeLastText: ">>",
            loadMessAge: "გთხოვთ დაიცადოთ...",
            invalidMessAge: "შეყვანილია არასწორი მონაცემები!"
        },

        loadIndicator: {
            messAge: "მიმდინარეობს ჩატვირთვა..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "ძებნა",
                insertModeButtonTooltip: "ჩანაწერის დამატება",
                editButtonTooltip: "შესწორება",
                deleteButtonTooltip: "წაშლა",
                searchButtonTooltip: "ძებნა",
                clearFilterButtonTooltip: "ფილტრის გასუფთავება",
                insertButtonTooltip: "დამატება",
                updateButtonTooltip: "შენახვა",
                cancelEditButtonTooltip: "გაუქმება"
            }
        },

        validators: {
            required: { messAge: "ველი აუცილებელია შესავსებად." },
            rangeLength: { messAge: "შეყვანილი ჩანაწერის ზომა არ ექვემდებარება დიაპაზონს." },
            minLength: { messAge: "შეყვანილი ჩანაწერის ზომა საკმაოდ პატარა არის." },
            maxLength: { messAge: "შეყვანილი ჩანაწერის ზომა საკმაოდ დიდი არის." },
            pattern: { messAge: "შეყვანილი მნიშვნელობა არ ემთხვევა მითითებულ შაბლონს." },
            range: { messAge: "შეყვანილი ინფორმაცია არ ჯდება დიაპაზონში." },
            min: { messAge: "შეყვანილი ინფორმაციის ზომა საკმაოდ პატარა არის." },
            max: { messAge: "შეყვანილი ინფორმაციის ზომა საკმაოდ დიდი არის." }
        }
    };

}(jsGrid, jQuery));
