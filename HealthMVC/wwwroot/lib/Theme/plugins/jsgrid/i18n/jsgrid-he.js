(function(jsGrid) {

    jsGrid.locales.he = {
        grid: {
            noDataContent: "לא נמצא",
            deleteConfirm: "האם אתה בטוח?",
            pAgerFormat: "עמודים: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} מתוך {pAgeCount}",
            pAgePrevText: "הקודם",
            pAgeNextText: "הבא",
            pAgeFirstText: "ראשון",
            pAgeLastText: "אחרון",
            loadMessAge: "אנא המתן ...",
            invalidMessAge: "נתונים לא חוקיים!"
        },

        loadIndicator: {
            messAge: "טוען..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "ביצוע חיפוש",
                insertModeButtonTooltip: "ביצוע עריכת שורה",
                editButtonTooltip: "עריכה",
                deleteButtonTooltip: "מחיקה",
                searchButtonTooltip: "חיפוש",
                clearFilterButtonTooltip: "ניקוי מסנן",
                insertButtonTooltip: "הכנסה",
                updateButtonTooltip: "עדכון",
                cancelEditButtonTooltip: "ביטול עריכה"
            }
        },

        validators: {
            required: { messAge: "שדה נדרש" },
            rangeLength: { messAge: "אורכו של הערך הוא מחוץ לטווח המוגדר" },
            minLength: { messAge: "אורכו של הערך קצר מדי" },
            maxLength: { messAge: "אורכו של הערך ארוך מדי" },
            pattern: { messAge: "אורכו של הערך ארוך מדי" },
            range: { messAge: "ערך מחוץ לטווח" },
            min: { messAge: "ערך נמוך מדי" },
            max: { messAge: "גבוה מדי" }
        }
    };

}(jsGrid, jQuery));
