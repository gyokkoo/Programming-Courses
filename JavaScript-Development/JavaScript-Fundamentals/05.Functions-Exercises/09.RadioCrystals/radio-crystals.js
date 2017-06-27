function radioCrystals(args) {
    class Crystal {
        constructor(microns, targetMicrons) {
            console.log(`Processing chunk ${microns} microns`);
            this.microns = microns;
            this.targetMicrons = targetMicrons;
            this.cuts = 0;
            this.laps = 0;
            this.grinds = 0;
            this.etches = 0;
        }

        cut() {
            this.microns /= 4;
            this.cuts++;
        }

        lap() {
            this.microns *= 0.8;
            this.laps++;
        }

        grind() {
            this.microns -= 20;
            this.grinds++;
        }

        etch() {
            this.microns -= 2;
            this.etches++;
        }

        xRay() {
            this.microns++;
        }

        check() {
            if (this.targetMicrons === this.microns) {
                console.log(`Finished crystal ${targetMicrons} microns`)
                return true;
            }
            return false
        }
        wash() {
            this.microns = Math.floor(this.microns);
            console.log('Transporting and washing')
        }
    }

    let targetMicrons = args[0];
    for (let i = 1; i < args.length; i++) {
        let crystal = new Crystal(args[i], targetMicrons);
        while (targetMicrons <= crystal.microns / 4) {
            crystal.cut();
        }
        console.log(`Cut x${crystal.cuts}`);
        crystal.wash();

        if (crystal.check()) {
            continue;
        }

        while (targetMicrons <= crystal.microns * 0.8) {
            crystal.lap();
        }
        console.log(`Lap x${crystal.laps}`);
        crystal.wash();
        if (crystal.check()) {
            continue;
        }

        while (targetMicrons <= crystal.microns - 20) {
            crystal.grind();
        }
        console.log(`Grind x${crystal.grinds}`);
        crystal.wash();
        if (crystal.check()) {
            continue;
        }

        while (targetMicrons <= crystal.microns - 2) {
            crystal.etch();
        }
        console.log(`Etch x${crystal.etches}`);
        crystal.wash();
        if (crystal.check()) {
            continue;
        }

        crystal.xRay();
        crystal.check();
    }
}

// TODO: Fix bug and get 100/100 points!