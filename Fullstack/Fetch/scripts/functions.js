
export async function fetchCities() {
    let resurceId = 'e9701dcb-9f1c-43bb-bd44-eb380ade542f';
    let limit = document.querySelector('#limit').value;
    let data = await fetch(`https://data.gov.il/api/3/action/datastore_search?resource_id=${resurceId}&limit=${limit}`);
    let json = await data.json();
    let cities = json.result.records;
    let resultDiv = document.querySelector('#result');
    resultDiv.innerHTML = '';

    cities.forEach(city => {
        let cityDiv = document.createElement('div');
        cityDiv.innerHTML = `<h3>${city.name_in_hebrew} (${city.symbol_number})</h3>`;
        resultDiv.appendChild(cityDiv);
    });
}

export async function fetchCities2() {
    if(document.querySelector('#autocomplete-input').value.length < 3) {
        console.log('Please enter at least 3 characters to search for cities.');
        return;
    }
    let resurceId = 'e9701dcb-9f1c-43bb-bd44-eb380ade542f';
    let input = document.querySelector('#autocomplete-input').value;
    let data = await fetch(`https://data.gov.il/api/3/action/datastore_search?resource_id=${resurceId}&q=${input}`);
    let json = await data.json();
    let cities = json.result.records;
    let datalist = document.querySelector('#autocomplete-list');
    datalist.innerHTML = '';
    cities.forEach(city => {
        let option = document.createElement('option');
        option.value = city.name_in_hebrew;
        datalist.appendChild(option);
    });
}