addCheckboxListeners();
getSelectedOptions();

const submitButton = document.querySelector("#submit");
submitButton.addEventListener("click", queryAccts);

const saveButton = document.querySelector("#saveGraph");
saveButton.addEventListener("click", saveGraph);

const closeButton = document.querySelector("#closePopUp");
closeButton.addEventListener("click", closePopUp);

function getSelectedOptions(){
    var checkedCheckboxes = document.querySelectorAll(`.accounts input[type='checkbox']:checked`);
    var selectedOptions = Array.from(checkedCheckboxes).map(checkbox => checkbox.value);
    console.log(selectedOptions);
    return selectedOptions;
}

function addCheckboxListeners() {
    document.querySelectorAll("input[type='checkbox']").forEach(checkbox => {
        checkbox.addEventListener('change', (event) => {
            let childCheckboxes = event.target.closest('li').querySelectorAll("input[type='checkbox']");
            childCheckboxes.forEach(childCheckbox => {
                if (childCheckbox !== event.target) {
                    childCheckbox.checked = event.target.checked;
                }
            });
        });
        this.updateParentCheckbox
    });
}

function updateParentCheckbox(childCheckbox) {
    var parentLi = childCheckbox.target.closest('ul').closest('li');
    if (!parentLi) return;
    let parentCheckbox = parentLi.querySelector('input[type="checkbox"]');
    let siblingCheckboxes = parentLi.querySelectorAll('li input[type="checkbox"]');
    parentCheckbox.checked = Array.from(siblingCheckboxes).every(checkbox => checkbox.checked);

    if (parentLi.closest('ul').closest('li')) {
        this.updateParentCheckbox(parentCheckbox);
    }
}

function queryAccts() {
    console.log("querying Account data");
    var selectedAccts = getSelectedOptions();
}

function saveGraph() {
    console.log("Saving graph");
    var submitButton = document.querySelector('.pop_up');
    submitButton.style.display = 'flex';
    var filterBox = document.querySelector('.graphInfo');
    filterBox.style.display = 'none';
}

function closePopUp() {
    console.log("closing pop up");
    var submitButton = document.querySelector('.pop_up');
    submitButton.style.display = 'none';
    var filterBox = document.querySelector('.graphInfo');
    filterBox.style.display = 'flex';
}