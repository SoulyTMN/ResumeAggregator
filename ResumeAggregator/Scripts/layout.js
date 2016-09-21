function updateDatabaseDebug() {
    if (!confirm("Обновить базу резюме?")) {
        return;
    }

    $.ajax({
        type: "post",
        async: false,
        url: "../Home/RefreshData",
        data: {
            jsonResponse: "https://ekb.zarplata.ru/api/v1/resumes/?city_id=994"
        },
        success: function (data) {
            alert(data);
        }
    });
}

function updateDatabase() {
    if (!confirm("Обновить базу резюме?")) {
        return;
    }

    $.ajax("https://ekb.zarplata.ru/api/v1/resumes/?city_id=994")
    .done(function (data) {
        $.ajax({
            type: "post",
            async: false,
            url: "../Home/RefreshData",
            data: {
                jsonResponse: JSON.stringify(data, null, 2)
            },
            success: function (data) {
                alert(data);
                location.reload();
            }
        });
    });
}