function sortTickets(ticketsData, sortingCriteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let tickets = [];
    for (let ticket of ticketsData) {
        let ticketTokens = ticket.split('|');
        tickets.push(new Ticket(ticketTokens[0], Number(ticketTokens[1]), ticketTokens[2]));
    }

    let sortedTickets = [];
    if (sortingCriteria == "destination") {
        sortedTickets = tickets.sort((t1, t2) => t1.destination.localeCompare(t2.destination));
    } else if (sortingCriteria == "price") {
        sortedTickets = tickets.sort((t1, t2) => t1.price - t2.price);
    } else if (sortingCriteria == "status") {
        sortedTickets = tickets.sort((t1, t2) => t1.status.localeCompare(t2.status));
    }

    return sortedTickets;
}

console.log(sortTickets(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'destination'
));