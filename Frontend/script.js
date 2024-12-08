document.getElementById('cardNumber').addEventListener('input', function(event) {
    this.value = this.value.replace(/[^0-9]/g, '');  // Allow only numbers
});

document.getElementById('cardForm').addEventListener('submit', async function(event) {
    event.preventDefault();
    const cardNumber = document.getElementById('cardNumber').value;

    // Show loading spinner
    document.getElementById('loading').style.display = 'inline-block';
    document.getElementById('result').innerHTML = '';  // Clear previous result

    // API Call
    try {
        const response = await fetch('https://localhost:5001/api/CardValidator', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ cardNumber })
        });

        // Hide loading spinner
        document.getElementById('loading').style.display = 'none';

        if (response.ok) {
            const result = await response.json();
            const formattedCardNumber = formatCardNumber(cardNumber);
            document.getElementById('result').innerHTML = `
                <div class="alert alert-success">
                    ${result.message}
                </div>
                <p><strong>Formatted Card Number:</strong> ${formattedCardNumber}</p>
            `;
            // Hide Validate button and show "Check Another Card" button
            document.querySelector('button').style.display = 'none';
            document.getElementById('checkAnother').style.display = 'block';
        } else {
            document.getElementById('result').innerHTML = '<div class="alert alert-danger">Invalid card number or server error. Please try again.</div>';
        }
    } catch (error) {
        // Hide loading spinner
        document.getElementById('loading').style.display = 'none';
        document.getElementById('result').innerHTML = '<div class="alert alert-danger">Invalid card number or server error. Please try again.</div>';
    }
});

// Format the card number in groups of 4 digits (e.g., 4111 1111 1111 1111)
function formatCardNumber(cardNumber) {
    return cardNumber.replace(/(\d{4})(?=\d)/g, '$1 ');
}

// Reset the page for another validation
document.getElementById('checkAnother').addEventListener('click', function() {
    // Reset the form and hide the result
    document.getElementById('cardForm').reset();
    document.getElementById('result').innerHTML = '';
    
    // Show the Validate button and hide the Check Another button
    document.querySelector('button').style.display = 'block';
    document.getElementById('checkAnother').style.display = 'none';
});
