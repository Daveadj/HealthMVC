(function(jsGrid) {

    jsGrid.locales["zh-tw"] = {
        grid: {
            noDataContent: "暫無資料",
            deleteConfirm: "確認刪除？",
            pAgerFormat: "頁碼: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} / {pAgeCount}",
            pAgePrevText: "上一頁",
            pAgeNextText: "下一頁",
            pAgeFirstText: "第一頁",
            pAgeLastText: "最後一頁",
            loadMessAge: "請稍候...",
            invalidMessAge: "輸入資料不正確"
        },

        loadIndicator: {
            messAge: "載入中..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "切換為搜尋",
                insertModeButtonTooltip: "切換為新增",
                editButtonTooltip: "編輯",
                deleteButtonTooltip: "刪除",
                searchButtonTooltip: "搜尋",
                clearFilterButtonTooltip: "清除搜尋條件",
                insertButtonTooltip: "新增",
                updateButtonTooltip: "修改",
                cancelEditButtonTooltip: "取消編輯"
            }
        },

        validators: {
            required: { messAge: "欄位必填" },
            rangeLength: { messAge: "欄位字串長度超出範圍" },
            minLength: { messAge: "欄位字串長度太短" },
            maxLength: { messAge: "欄位字串長度太長" },
            pattern: { messAge: "欄位字串不符合規則" },
            range: { messAge: "欄位數值超出範圍" },
            min: { messAge: "欄位數值太小" },
            max: { messAge: "欄位數值太大" }
        }
    };

}(jsGrid, jQuery));
