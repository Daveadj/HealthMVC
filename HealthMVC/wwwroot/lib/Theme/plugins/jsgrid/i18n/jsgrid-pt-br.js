(function(jsGrid) {

    jsGrid.locales["pt-br"] = {
        grid: {
            noDataContent: "Não encontrado",
            deleteConfirm: "Você tem certeza que deseja remover este item?",
            pAgerFormat: "Páginas: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} de {pAgeCount}",
            pAgePrevText: "Anterior",
            pAgeNextText: "Seguinte",
            pAgeFirstText: "Primeira",
            pAgeLastText: "Última",
            loadMessAge: "Por favor, espere...",
            invalidMessAge: "Dados inválidos!"
        },

        loadIndicator: {
            messAge: "Carregando..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Mudar para busca",
                insertModeButtonTooltip: "Mudar para inserção",
                editButtonTooltip: "Editar",
                deleteButtonTooltip: "Remover",
                searchButtonTooltip: "Buscar",
                clearFilterButtonTooltip: "Remover filtro",
                insertButtonTooltip: "Adicionar",
                updateButtonTooltip: "Atualizar",
                cancelEditButtonTooltip: "Cancelar Edição"
            }
        },

        validators: {
            required: { messAge: "Campo obrigatório" },
            rangeLength: { messAge: "O valor esta fora do intervaldo definido" },
            minLength: { messAge: "O comprimento do valor é muito curto" },
            maxLength: { messAge: "O comprimento valor é muito longo" },
            pattern: { messAge: "O valor informado não é compatível com o padrão" },
            range: { messAge: "O valor informado esta fora do limite definido" },
            min: { messAge: "O valor é muito curto" },
            max: { messAge: "O valor é muito longo" }
        }
    };

}(jsGrid, jQuery));
