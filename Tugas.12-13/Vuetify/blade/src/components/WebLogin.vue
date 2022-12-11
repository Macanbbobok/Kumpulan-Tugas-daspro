<template>
    <v-container>
        <v-form v-modul ="valid">
            <v-text-field
                v-model="name"
                :rules="nameRules"
                :counter="10"
                label="name"
                required
                >
            </v-text-field>
            <v-text-field
            v-model ="email"
            :rules="emailRules"
            label="email"
            required></v-text-field>
            <v-text-field
            v-model ="pesan"
            :rules ="pesanRules"
            label="pesan"
            multi-line></v-text-field>
           
        </v-form>
    </v-container>
</template>
<script>
export default{
    data:() =>({
        valid:false,
        name :'',
        nameRules:[
            v => !!v ||  'name is  required',
            v => v.length <= 10 || 'Name must be less tham 10 characters'
        ],
        email:'',
        emailRules: [
            v => !! 'Email is required',
            v=> /.+@.+/.test(v) || 'Email must be valid'
        ],
        pesan: ''

    })
}