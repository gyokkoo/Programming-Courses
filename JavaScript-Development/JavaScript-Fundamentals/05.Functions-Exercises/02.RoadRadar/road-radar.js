function roadRadar(args) {
    let speed = Number(args[0]);
    let zone = args[1];

    let speedLimit = getLimit(zone);
    let result = (getInfraction(speed, speedLimit));
    if (result) {
        console.log(result);
    }

    function getInfraction(speed, limit) {
        let overSpeed = speed - limit;
        if (overSpeed <= 0) {
            return false;
        } else {
            if (0 <= overSpeed && overSpeed <= 20) {
                return 'speeding';
            } else if (20 < overSpeed && overSpeed <= 40) {
                return 'excessive speeding';
            } else {
                return 'reckless driving';
            }
        }
    }

    function getLimit(zone) {
        switch(zone) {
            case 'motorway': return 130;
            case 'interstate': return 90;
            case 'city': return 50;
            case 'residential': return 20;
        }
    }
}

roadRadar(['21', 'residential']);