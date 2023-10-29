(function(jsGrid) {

    jsGrid.locales.ru = {
        grid: {
            noDataContent: "Данных не найдено",
            deleteConfirm: "Вы действительно хотите удалить запись?",
            pAgerFormat: "Страницы: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} из {pAgeCount}",
            pAgePrevText: "<",
            pAgeNextText: ">",
            pAgeFirstText: "<<",
            pAgeLastText: ">>",
            loadMessAge: "Пожалуйста, подождите...",
            invalidMessAge: "Введены неверные данные!"
        },

        loadIndicator: {
            messAge: "Загрузка..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Поиск",
                insertModeButtonTooltip: "Добавить запись",
                editButtonTooltip: "Изменить",
                deleteButtonTooltip: "Удалить",
                searchButtonTooltip: "Найти",
                clearFilterButtonTooltip: "Очистить фильтр",
                insertButtonTooltip: "Добавить",
                updateButtonTooltip: "Сохранить",
                cancelEditButtonTooltip: "Отменить"
            }
        },

        validators: {
            required: { messAge: "Поле обязательно для заполения" },
            rangeLength: { messAge: "Длинна введенного значения вне допустимого диапазона" },
            minLength: { messAge: "Введенное значение слишком короткое" },
            maxLength: { messAge: "Введенное значение слишком длинное" },
            pattern: { messAge: "Введенное значение не соответствует заданному шаблону" },
            range: { messAge: "Введенное значение вне допустимого диапазона" },
            min: { messAge: "Введенное значение слишком маленькое" },
            max: { messAge: "Введенное значение слишком большое" }
        }
    };

}(jsGrid, jQuery));

