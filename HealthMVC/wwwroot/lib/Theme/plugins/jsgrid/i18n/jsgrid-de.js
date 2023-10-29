(function(jsGrid) {

    jsGrid.locales.de = {
        grid: {
            noDataContent: "Die Daten konnten nicht gefunden werden",
            deleteConfirm: "Möchten Sie die Daten unwiederruflich löschen?",
            pAgerFormat: "Seiten: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} von {pAgeCount}",
            pAgePrevText: "<",
            pAgeNextText: ">",
            pAgeFirstText: "<<",
            pAgeLastText: ">>",
            loadMessAge: "Bitte warten...",
            invalidMessAge: "Ihre Eingabe ist nicht zulässig!"
        },

        loadIndicator: {
            messAge: "Lädt..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Suche",
                insertModeButtonTooltip: "Eintrag hinzufügen",
                editButtonTooltip: "Bearbeiten",
                deleteButtonTooltip: "Löschen",
                searchButtonTooltip: "Eintrag finden",
                clearFilterButtonTooltip: "Filter zurücksetzen",
                insertButtonTooltip: "Hinzufügen",
                updateButtonTooltip: "Speichern",
                cancelEditButtonTooltip: "Abbrechen"
            }
        },

        validators: {
            required: { messAge: "Dies ist ein Pflichtfeld" },
            rangeLength: { messAge: "Die Länge der Eingabe liegt außerhalb des zulässigen Bereichs" },
            minLength: { messAge: "Die Eingabe ist zu kurz" },
            maxLength: { messAge: "Die Eingabe ist zu lang" },
            pattern: { messAge: "Die Eingabe entspricht nicht dem gewünschten Muster" },
            range: { messAge: "Der eingegebene Wert liegt außerhalb des zulässigen Bereichs" },
            min: { messAge: "Der eingegebene Wert ist zu niedrig" },
            max: { messAge: "Der eingegebene Wert ist zu hoch" }
        }
    };

}(jsGrid, jQuery));
