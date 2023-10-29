(function(jsGrid) {

    jsGrid.locales["zh-cn"] = {
        grid: {
            noDataContent: "暂无数据",
            deleteConfirm: "确认删除？",
            pAgerFormat: "页码: {first} {prev} {pAges} {next} {last} &nbsp;&nbsp; {pAgeIndex} / {pAgeCount}",
            pAgePrevText: "上一页",
            pAgeNextText: "下一页",
            pAgeFirstText: "第一页",
            pAgeLastText: "最后页",
            loadMessAge: "请稍后...",
            invalidMessAge: "数据有误！"
        },

        loadIndicator: {
            messAge: "载入中..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "切换为搜索",
                insertModeButtonTooltip: "切换为新增",
                editButtonTooltip: "编辑",
                deleteButtonTooltip: "删除",
                searchButtonTooltip: "搜索",
                clearFilterButtonTooltip: "清空过滤",
                insertButtonTooltip: "插入",
                updateButtonTooltip: "更新",
                cancelEditButtonTooltip: "取消编辑"
            }
        },

        validators: {
            required: { messAge: "字段必填" },
            rangeLength: { messAge: "字段值长度超过定义范围" },
            minLength: { messAge: "字段长度过短" },
            maxLength: { messAge: "字段长度过长" },
            pattern: { messAge: "字段值不符合定义规则" },
            range: { messAge: "字段值超过定义范围" },
            min: { messAge: "字段值太小" },
            max: { messAge: "字段值太大" }
        }
    };

}(jsGrid, jQuery));
