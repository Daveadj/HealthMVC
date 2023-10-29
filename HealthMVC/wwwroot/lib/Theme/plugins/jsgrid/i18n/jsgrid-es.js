(function(jsGrid) {

    jsGrid.locales.es = {
        grid: {
            noDataContent: "No encontrado",
            deleteConfirm: "¿Está seguro?",
            pAgerFormat: "Paginas: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} de {pAgeCount}",
            pAgePrevText: "Anterior",
            pAgeNextText: "Siguiente",
            pAgeFirstText: "Primero",
            pAgeLastText: "Ultimo",
            loadMessAge: "Por favor, espere...",
            invalidMessAge: "¡Datos no válidos!"
        },

        loadIndicator: {
            messAge: "Cargando..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Cambiar a búsqueda",
                insertModeButtonTooltip: "Cambiar a inserción",
                editButtonTooltip: "Editar",
                deleteButtonTooltip: "Suprimir",
                searchButtonTooltip: "Buscar",
                clearFilterButtonTooltip: "Borrar filtro",
                insertButtonTooltip: "Insertar",
                updateButtonTooltip: "Actualizar",
                cancelEditButtonTooltip: "Cancelar edición"
            }
        },

        validators: {
            required: { messAge: "Campo requerido" },
            rangeLength: { messAge: "La longitud del valor está fuera del intervalo definido" },
            minLength: { messAge: "La longitud del valor es demasiado corta" },
            maxLength: { messAge: "La longitud del valor es demasiado larga" },
            pattern: { messAge: "El valor no se ajusta al patrón definido" },
            range: { messAge: "Valor fuera del rango definido" },
            min: { messAge: "Valor demasiado bajo" },
            max: { messAge: "Valor demasiado alto" }
        }
    };

}(jsGrid, jQuery));
