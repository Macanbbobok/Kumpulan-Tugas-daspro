<template>
    <v-toolbar color="green darken-4" dark>
    <v-toolbar-side-icon @click.stop= "drawer = !drawer "></v-toolbar-side-icon>
        <div class="hidden-sm-and-down">
            <v-btn flat>Home</v-btn>
             <v-btn flat>Profile</v-btn>
             <v-btn flat>Unit/Lembaga</v-btn> 
             <v-btn flat>Akademik</v-btn>
             <v-btn flat>Dokumen</v-btn>
             <v-btn flat>Galery</v-btn>
             <V-btn flat>Peta</V-btn>
             <V-btn flat>Video Profile</V-btn>
            <router-link to ="/login">
                <v-btn flat>Kontak</v-btn>
            </router-link>
        </div>
        <div class = "hidden-sm-and-down">
            <v-navigation-drawer
            v-model="drawer"
            absolute
            temporary
            height ="800px">
            <v-List class ="pa-1">
            <v-List-tile avatar>
            <v-List-tile-avatar>
                <img src="https://randomuser.me/api/portrait/men/85.jpg">
            </v-List-tile-avatar>
            <v-List-tile-content>
                <v-List-tile-title>John Leider</v-List-tile-title>
            </v-List-tile-content>
            </v-List-tile>
            </v-List>
            <v-List class="pt-0" dense>
                <v-divider></v-divider>
                <v-list-tile
                v-for="item in items"
                :key = "item.title">
                <v-List-tile-action>
                    <v-icon>{{item.icon}}</v-icon>
                </v-List-tile-action>
                <v-List-content>
                <v-List-tile-title>{{item.title}}</v-List-tile-title>
                </v-List-content>
            </v-List-tile>
            </v-List>
            </v-navigation-drawer>
            
        </div>
    </v-toolbar>
</template>
<script>
export default {
    data(){
        return{
            drawer:null,
            items:[
                {title : 'Home', icon:'dashboard'},
                {title:'About', icon:'questions_answer'}
            ]
        }
    }
}
</script>