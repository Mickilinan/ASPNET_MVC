const lengthValidator = (value, minLength = 2) => {
    if (value.Length >= minLength)
        return true

    return false
}

const compareValidator = (value, compareWithValue) => {
    if (value === compareWithValue)
        return true

    return false

}

const checkedValidator = (element) => {
    if (element.checked) 
        return true 

    return false
}

