addCheckboxListeners();
getSelectedOptions();

function getSelectedOptions(){
    var checkedCheckboxes = document.querySelectorAll(`.accounts input[type='checkbox']:checked`);
    var selectedOptions = Array.from(checkedCheckboxes).map(checkbox => checkbox.value);
    console.log(selectedOptions);
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