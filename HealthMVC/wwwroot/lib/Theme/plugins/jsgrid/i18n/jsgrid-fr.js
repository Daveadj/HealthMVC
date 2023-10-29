(function(jsGrid) {

    jsGrid.locales.fr = {
        grid: {
            noDataContent: "Pas de données",
            deleteConfirm: "Êtes-vous sûr ?",
            pAgerFormat: "PAges: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} de {pAgeCount}",
            pAgePrevText: "<",
            pAgeNextText: ">",
            pAgeFirstText: "<<",
            pAgeLastText: ">>",
            loadMessAge: "Chargement en cours...",
            invalidMessAge: "Des données incorrectes sont entrés !"
        },

        loadIndicator: {
            messAge: "Chargement en cours..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Recherche",
                insertModeButtonTooltip: "Ajouter une entrée",
                editButtonTooltip: "Changer",
                deleteButtonTooltip: "Effacer",
                searchButtonTooltip: "Trouve",
                clearFilterButtonTooltip: "Effacer",
                insertButtonTooltip: "Ajouter",
                updateButtonTooltip: "Sauvegarder",
                cancelEditButtonTooltip: "Annuler"
            }
        },

        validators: {
            required: { messAge: "Champ requis" },
            rangeLength: { messAge: "Longueur de la valeur du champ est hors de la plAge définie" },
            minLength: { messAge: "La valeur du champ est trop court" },
            maxLength: { messAge: "La valeur du champ est trop long" },
            pattern: { messAge: "La valeur du champ ne correspond pas à la configuration définie" },
            range: { messAge: "La valeur du champ est hors de la plAge définie" },
            min: { messAge: "La valeur du champ est trop petit" },
            max: { messAge: "La valeur du champ est trop grande" }
        }
    };

}(jsGrid, jQuery));

