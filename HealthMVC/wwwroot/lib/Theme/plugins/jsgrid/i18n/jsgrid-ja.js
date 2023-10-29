(function(jsGrid) {

    jsGrid.locales.ja = {
        grid: {
            noDataContent: "データが見つかりません。",
            deleteConfirm: "削除しますよろしですか。",
            pAgerFormat: "頁: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; 【{pAgeIndex}／{pAgeCount}】",
            pAgePrevText: "前",
            pAgeNextText: "次",
            pAgeFirstText: "最初",
            pAgeLastText: "最後",
            loadMessAge: "しばらくお待ちください…",
            invalidMessAge: "入力されたデータが不正です。"
        },

        loadIndicator: {
            messAge: "処理中…"
        },

        fields: {
            control: {
                searchModeButtonTooltip: "検索モードへ",
                insertModeButtonTooltip: "登録モードへ",
                editButtonTooltip: "編集",
                deleteButtonTooltip: "削除",
                searchButtonTooltip: "フィルター",
                clearFilterButtonTooltip: "クリア",
                insertButtonTooltip: "登録",
                updateButtonTooltip: "更新",
                cancelEditButtonTooltip: "編集戻す"
            }
        },

        validators: {
            required: { messAge: "項目が必要です。" },
            rangeLength: { messAge: "項目の桁数が範囲外です。" },
            minLength: { messAge: "項目の桁数が超過しています。" },
            maxLength: { messAge: "項目の桁数が不足しています。" },
            pattern: { messAge: "項目の値がパターンに一致しません。" },
            range: { messAge: "項目の値が範囲外です。" },
            min: { messAge: "項目の値が超過しています。" },
            max: { messAge: "項目の値が不足しています。" }
        }
    };

}(jsGrid, jQuery));