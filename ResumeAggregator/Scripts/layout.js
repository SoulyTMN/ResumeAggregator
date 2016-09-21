var GLOBAL_FETCH;
var GLOBAL_FETCH_OFFSET = 0;
var GLOBAL_FETCH_END = 200;
var GLOBAL_LAST_RESULT;

function fetchData() {
    if (GLOBAL_FETCH_OFFSET >= GLOBAL_FETCH_END) {
        clearInterval(GLOBAL_FETCH);
        alert(GLOBAL_LAST_RESULT);
        location.reload();
    }
    else {
        $.ajax("https://ekb.zarplata.ru/api/v1/resumes/?city_id=994&limit=100&offset=" + GLOBAL_FETCH_OFFSET)
    .done(function (data) {
        $.ajax({
            type: "post",
            async: false,
            url: "../Home/RefreshData",
            data: {
                jsonResponse: JSON.stringify(data, null, 2)
            },
            success: function (data) {
                GLOBAL_FETCH_OFFSET = GLOBAL_FETCH_OFFSET + 100;
                GLOBAL_LAST_RESULT = data;
            },
            error: function (data) {
                GLOBAL_FETCH_OFFSET = GLOBAL_FETCH_END + 1;
                GLOBAL_LAST_RESULT = data;
            }
        });
    });
    }

}

function updateDatabase() {
    if (!confirm("Обновить базу резюме?")) {
        return;
    } 
    GLOBAL_FETCH = setInterval(fetchData, 2000);
}