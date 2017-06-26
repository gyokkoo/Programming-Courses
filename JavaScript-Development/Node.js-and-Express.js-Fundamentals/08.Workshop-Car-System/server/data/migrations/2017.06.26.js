db.getCollection('cars').update({}, {$set: { createdOn: Date.now() }}, {multi: true})
db.getCollection('cars').find({}, { $set: { isRented: false } }, { multi: true })
