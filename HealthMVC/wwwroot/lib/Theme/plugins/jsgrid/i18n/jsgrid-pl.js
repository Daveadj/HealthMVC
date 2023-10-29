(function(jsGrid) {

    jsGrid.locales.pl = {
        grid: {
            noDataContent: "Nie znaleziono",
            deleteConfirm: "Czy jesteś pewien?",
            pAgerFormat: "Strony: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} z {pAgeCount}",
            pAgePrevText: "Poprzednia",
            pAgeNextText: "Następna",
            pAgeFirstText: "Pierwsza",
            pAgeLastText: "Ostatnia",
            loadMessAge: "Proszę czekać...",
            invalidMessAge: "Wprowadzono nieprawidłowe dane!"
        },

        loadIndicator: {
            messAge: "Ładowanie..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Wyszukiwanie",
                insertModeButtonTooltip: "Dodawanie",
                editButtonTooltip: "Edytuj",
                deleteButtonTooltip: "Usuń",
                searchButtonTooltip: "Szukaj",
                clearFilterButtonTooltip: "Wyczyść filtr",
                insertButtonTooltip: "Dodaj",
                updateButtonTooltip: "Aktualizuj",
                cancelEditButtonTooltip: "Anuluj edytowanie"
            }
        },

        validators: {
            required: {
                messAge: "Pole jest wymagane"
            },
            rangeLength: {
                messAge: "Długość wartości pola znajduje się poza zdefiniowanym zakresem"
            },
            minLength: {
                messAge: "Wartość pola jest zbyt krótka"
            },
            maxLength: {
                messAge: "Wartość pola jest zbyt długa"
            },
            pattern: {
                messAge: "Wartość pola nie zgadza się ze zdefiniowanym wzorem"
            },
            range: {
                messAge: "Wartość pola znajduje się poza zdefiniowanym zakresem"
            },
            min: {
                messAge: "Wartość pola jest zbyt mała"
            },
            max: {
                messAge: "Wartość pola jest zbyt duża"
            }
        }
    };

}(jsGrid, jQuery));
